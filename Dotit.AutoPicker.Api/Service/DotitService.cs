using DotIt.AutoPickerApi.Models;
using DotIt.AutoPickerApi.Persistance.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Service
{
    public interface IDotitService
    {
        #region Picker Orders
        Task<bool> AssignOrderToPickerAsync(PickerModel pickerModel);
        Task<List<OrderHeadModel>> GetDotitPickerOrdersAsync(string dcdUserID);
        Task<List<OrderDetailModel>> GetDotItOrderDetails(int[] Orders, string dcdUserId, int statuscode = 0);
        Task<string> PickLineItemsAsync(int ordernum, int orderline, string status, string partno, string binno);

        Task<bool> OrderCompleteOrNotAsync(int ordernum);

        #endregion

        #region Picker
        Task<bool> UpdateProfileAsync(PickerModel pickerModel);
        Task<List<PickerModel>> GetDotitPickersAsync(string DcdUserID);


        Task<ResponseModel> DeletePickerAsync(PickerModel pickerModel);
        #endregion

    }



    public class DotitService : IDotitService
    {
        private readonly IPickerRepository _PickerRepository;
        private IEpicorServiceApi _EpicorServiceApi;

        public DotitService(IPickerRepository pickerRepository, IEpicorServiceApi epicorServiceApi)
        {
            _PickerRepository = pickerRepository;
            _EpicorServiceApi = epicorServiceApi;
        }


        #region Private Method
        private async Task<bool> IsOrderCompleteAsync(List<OrderDetailModel> lines)
        {
            //DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

            try
            {
                // return true;
                List<PartBinModel> PartBins;
                Boolean isComplete = true;

                foreach (OrderDetailModel line in lines)
                {
                    PartBins = await _EpicorServiceApi.GetPartBinAsync(line.PartNum);
                    var bins = from pb in PartBins where pb.PartNum == line.PartNum && pb.WhseCode == "Main" select pb;
                    double qtyOnHand = 0.0;

                    foreach (PartBinModel pb in bins)
                    {
                        qtyOnHand += pb.QtyOnHand;
                    }

                    if (line.OrderQty <= (Double)qtyOnHand)
                    {
                        // DLog.Log("Order: " + orderNum + " Part: " + line.PartNum + " has enough inventory: " + qtyOnHand + " to fulfill line request: " + line.OrderQty);
                    }
                    else
                    {
                        //DLog.Log("Part: " + line.PartNum + " does not have enough inventory: " + qtyOnHand + " to fulfill line request: " + line.OrderQty);
                        isComplete = false;
                        break;
                    }
                }

                return isComplete;
            }
            catch (Exception ex)
            {
                //   DLog.LogErr(ex);
                return false;
            }
        }


        private Decimal CalculateWeightOpenLines(OrderHeadModel order, List<PartsModel> parts)
        {
            //DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
            //  List<PartsModel> Parts = GetParts();
            Decimal weight = 0.0m;

            try
            {
                //List<OrderDetailModel> lines = (from od in OrderDetails where od.OrderNum == orderNum && od.OpenLine == true select od).ToList<OrderDetailModel>();

                foreach (OrderDetailModel line in order.OrderDtls)
                {
                    Decimal itemWeight = parts.FirstOrDefault(p => p.PartNum == line.PartNum) != null ? parts.FirstOrDefault(p => p.PartNum == line.PartNum).GrossWeight : 0;
                    weight += itemWeight * (decimal)line.OrderQty;
                }
            }
            catch (Exception ex)
            {
                weight = -1.0m;
                //DLog.LogErr(ex, "Could not calculate weight of open line for order number: " + orderNum);
            }

            return weight;
        }
        #endregion
        public async Task<List<OrderHeadModel>> OrdersReadyToPickAsync(Int32 maxLines = 50, Decimal maxWeight = 150.0m, int maxOrder = 0, bool ncco = false)
        {
            // DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

            Decimal totalWeight = 0.0m;
            List<OrderHeadModel> listLines = new List<OrderHeadModel>();
            //List<Int32> orderSelected = new List<Int32>();

            var rsPotentialOrders = await _EpicorServiceApi.GetEpicoreOrderAsync();
            var parts = await _EpicorServiceApi.GetPartsAsync();

            // OrderDetails = GetOrderDetails();
            foreach (OrderHeadModel queue in rsPotentialOrders)
            {
                if (queue.CustNum == 1 && ncco == false)
                {
                    // DLog.Log("Skipping order: " + queue.OrderNum + " as picker is not assigned to NCCO orders");
                    continue;
                }

                //if (queue.CustNum != 1 && dotit == false)
                //{
                //   // DLog.Log("Skipping order: " + queue.orderNum + " as picker is not assigned to non NCCO orders");
                //    continue;
                //}

                //  Test to see if the order can be shipped complete.
                if (!await IsOrderCompleteAsync(queue.OrderDtls))
                {
                    //DLog.Log("Skipping Order: " + queue.orderNum + " due to lines not having enough inventory.");
                    continue;
                }

                //  How many lines is this order
                //totalLines += (from od in OrderDetails where od.OrderNum == queue.OrderNum && od.OpenLine == true select od).Count();

                //  If puts over max, then bail with orders
                if (maxLines < queue.TotalLines)
                {
                    // DLog.Log("Cutting off line assignment due to maxLine: " + maxLines + " exceeding totalLines: " + totalLines);
                    break;
                }

                Decimal orderWeight = CalculateWeightOpenLines(queue, parts);

                if (orderWeight < 0)
                {
                    //DLog.Log("Skipping order: " + queue.orderNum + " due to not being able to calculate weight", DLog.LogLevel.Warn, true);
                    continue;
                }

                totalWeight += orderWeight;

                if (maxWeight < totalWeight)
                {
                    // DLog.Log("Cutting off line assignment due to maxWeight: " + maxWeight + " exceeding totalLines: " + totalWeight);
                    break;
                }

                OrderHeadModel q = new OrderHeadModel();

                q = queue;
                //q.TotalLines = totalLines;
                q.TotalWgt_c = (double)totalWeight;

                listLines.Add(q);
            }


            return listLines;
        }


        public async Task<bool> AssignOrderToPickerAsync(PickerModel pickerModel)
        {
            // List<PickerModel> ListEmp = _pickerRepository.GetPickers(null, UserId).Where(x => Convert.ToDouble(x.MaxWeight) >= itemhm.TotalWgt_c).ToList();
            try
            {
                List<OrderHeadModel> dotItOrderList;
                // Pickerorder objPicker;

                //  List<PickOrderdetail> pickorderdetail = null;
                dotItOrderList = await _PickerRepository.GetDotItOrderAsync();
                var epicorOrder = await OrdersReadyToPickAsync();
                epicorOrder = epicorOrder.Where(f => !dotItOrderList.Select(p => p.OrderNum).Contains(f.OrderNum)).ToList();
                List<OrderHeadModel> nccoOrderList = epicorOrder.Where(f => f.Company.Equals("NCCO") && pickerModel.Ncco).ToList();
                List<OrderHeadModel> dirfOrderList = epicorOrder.Where(f => !f.Company.Equals("NCCO")).ToList();


                var dotItPickOrderList = dotItOrderList.Where(f => f.PickerUserId.Equals(pickerModel.DcdUserID) & !f.OrderPickStatus.Equals(OrderStatus.Complete.ToString()));
                int PickerTotalLineItems = dotItPickOrderList.Sum(f => f.TotalLines);
                int pickerAssinedOrders = pickerAssinedOrders = dotItPickOrderList.Count();
                bool CanAssignOrder = true;
                Parallel.ForEach(nccoOrderList, async (order) =>
                {
                    //       if (pickerAssinedOrders + 1 > pickerModel.MaxOrder) return false;
                    if (pickerAssinedOrders + 1 < pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) CanAssignOrder = false;
                    if (PickerTotalLineItems < pickerModel.MaxLines && pickerAssinedOrders + 1 > pickerModel.MaxOrder) CanAssignOrder = false;
                    if (pickerAssinedOrders + 1 > pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) CanAssignOrder = false;
                    if (CanAssignOrder && !ExistsDotitPickerOrder(order.OrderNum, dotItOrderList))
                    {
                        if (await _PickerRepository.AddPickerOrderAsync(order))
                        {
                            if (_PickerRepository.AddOrderLines(order.OrderDtls))
                            {

                                PickerTotalLineItems += order.OrderDtls.Count();
                                pickerAssinedOrders += 1;
                            }
                        }
                    }

                });
                if (CanAssignOrder)
                {
                    Parallel.ForEach(dirfOrderList, async (order) =>
                    {
                        //       if (pickerAssinedOrders + 1 > pickerModel.MaxOrder) return false;
                        if (pickerAssinedOrders + 1 < pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) CanAssignOrder = false;
                        if (PickerTotalLineItems < pickerModel.MaxLines && pickerAssinedOrders + 1 > pickerModel.MaxOrder) CanAssignOrder = false;
                        if (pickerAssinedOrders + 1 > pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) CanAssignOrder = false;
                        if (CanAssignOrder && !ExistsDotitPickerOrder(order.OrderNum, dotItOrderList))
                        {
                            if (await _PickerRepository.AddPickerOrderAsync(order))
                            {
                                if (_PickerRepository.AddOrderLines(order.OrderDtls))
                                {

                                    PickerTotalLineItems += order.OrderDtls.Count();
                                    pickerAssinedOrders += 1;
                                }
                            }
                        }

                    });
                }

            }
            catch (Exception ex)
            {
                // return false;
            }

            return true;
        }

        private bool ExistsDotitPickerOrder(int orderNum, List<OrderHeadModel> dotItOrderList)
        {
            return dotItOrderList.FirstOrDefault(f => f.OrderNum.Equals(orderNum)) != null;
        }


        public async Task<List<OrderHeadModel>> GetDotitPickerOrdersAsync(string dcdUserID)//This is a method 
        {
            List<OrderHeadModel> orderlist = null;
            try
            {

                var result = await _PickerRepository.GetDotItOrderAsync(null, dcdUserID);

                orderlist = result.Where(f => !f.OrderPickStatus.Equals(OrderStatus.Complete) & f.OrderDateTime < (DateTime.Now)).OrderByDescending(o => o.RequestDate).ToList();
                //if (SaleOrderList == null || SaleOrderList.Count() == 0)
                //    GetEpicorOrders();
                // JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderList["value"].ToString());
                foreach (var _Order in orderlist)
                {
                    _Order.OrderDateTime = Convert.ToDateTime(_Order.OrderDate);

                }

            }
            catch
            {

            }
            return orderlist;
        }

        public async Task<ResponseModel> DeletePickerAsync(PickerModel pickerModel)
        {
            var result = await _PickerRepository.UpdateProfileAsync(pickerModel);
            if (result)
            {
                return (new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Success, "Profile", "deleted") });
            }
            return (new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed, "Profile", "delete") });
        }

        public async Task<List<OrderDetailModel>> GetDotItOrderDetails(int[] Orders, string dcdUserId, int statuscode = 0)
        {
            var _result = _PickerRepository.GetDotItOrderDetailsAsync(Orders, dcdUserId, statuscode).Result.ToList().OrderBy(f => f.BinNum);
            foreach (var item in _result)
            {
                item.ImageContent = await _EpicorServiceApi.GetItemImageByPartNumberAsync(item.PartNum);
            }
            return _result.ToList();
        }


        public async Task<string> PickLineItemsAsync(int ordernum, int orderline, string status, string partno, string binno)
        {


            if (status == LineItemStatus.Picked.ToString())
            {
                return await _PickerRepository.UpdateDotitPickerOrderAsync(ordernum, LineItemStatus.Picked.ToString(), string.Empty, partno, (int)LineItemStatus.Picked);

            }
            //if (status == LineItemStatus.UnPicked.ToString())
            //{
            //    return await _PickerRepository.UpdateDotitPickerOrderAsync(ordernum, LineItemStatus.UnPicked.ToString(), string.Empty, partno, (int)LineItemStatus.UnPicked);

            //}

            else if (status == LineItemStatus.Quarentine.ToString())
            {

                return await _PickerRepository.UpdateDotitPickerOrderAsync(ordernum, OrderStatus.Hold.ToString(), status, partno, (int)LineItemStatus.Quarentine);


            }


            //if (status == LineItemStatus.Replenish.ToString())
            //{

            //   await  _PickerRepository.UpdateDotitPickerOrderAsync(ordernum, LineItemStatus.Replenish.ToString(), "NO", partno, (int)LineItemStatus.Replenish);

            //}
            //if (status == LineItemStatus.InventoryControl.ToString())
            //{
            //    String ResionPickFail = string.Format(" Part# {0} in bin location {1} has been InventoryControl,'" + PartNum + "','" + BinNum + "'", PartNum, BinNum);
            //   await  _PickerRepository.UpdateDotitPickerOrderAsync(ordernum, OrderStatus.Hold.ToString(), ResionPickFail, partno, (int)LineItemStatus.InventoryControl);


            //}
            return string.Empty;
        }

        public async Task<List<PickerModel>> GetDotitPickersAsync(string DcdUserID)
        {
            return await _PickerRepository.GetPickersAsync(dcduserid: DcdUserID);


        }




        public async Task<bool> OrderCompleteOrNotAsync(int ordernum)
        {
            return await _PickerRepository.OrderCompleteOrNotAsync(ordernum);
        }




        public async Task<bool> UpdateProfileAsync(PickerModel pickerModel)
        {
            return await _PickerRepository.UpdateProfileAsync(pickerModel);
        }


    }
}
