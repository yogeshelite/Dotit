using DotIt.AutoPicker.Data.DotIt;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Persistance.Repository;
using DotIt.AutoPicker.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Service
{
    public class OrderAssignPicker : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly DotitExtensionContext _DotitExtensionContext;
        private readonly IPickerRepository _pickerRepository;
        private StackTrace _stackTrace;

        ApiResponse _apiResponse;
        EpicorServiceApi _EpicorServiceApi;
        public OrderAssignPicker(IHostingEnvironment hostingEnvironment, DotitExtensionContext context, EpicorServiceApi epicorServiceApi)
        {
            _hostingEnvironment = hostingEnvironment;
            _DotitExtensionContext = context;
            _stackTrace = new StackTrace();
            _EpicorServiceApi = epicorServiceApi;
            _pickerRepository = new PickerRepository(_stackTrace);
        }

        private async Task<List<OrderDetailModel>> GetOrderDetailsAsync()
        {
            List<OrderDetailModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(Constant.EpicorApi_OrderDetailsFilter, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                List<OrderDetailModel> _result = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
                                if (_result != null)
                                {


                                    _result = _result.ToList();

                                    resultOrderList = _result.ToList();
                                }
                            }
                        }
                    }
                    else
                    {
                        //RedirectToAction("Error", "Home");
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.Message.ToString();
                }
            }
            return resultOrderList;


        }

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
        public async Task AssignOrdersToPickersAsync()
        {
            Pickerorder objPicker;
            List<OrderHeadModel> LisEmpOrder;
            List<Pickorderdetail> pickorderdetail = null;
            int PickerTotalLineItems = 0;// dotItPickOrderList.Sum(f => f.TotalLines);
            int pickerAssinedOrders = 0;// pickerAssinedOrders = dotItPickOrderList.Count();
            try
            {
                List<OrderHeadModel> OrderList = await OrdersReadyToPickAsync();

                List<PickerModel> ListEmp = _pickerRepository.GetPickers();


                foreach (OrderHeadModel order in OrderList)
                {
                    ListEmp = ListEmp.Where(x => Convert.ToDouble(x.MaxWeight) >= order.TotalWgt_c).ToList();

                    foreach (PickerModel pickerModel in ListEmp)
                    {
                        LisEmpOrder = _pickerRepository.GetDotItOrder(null, pickerModel.DcdUserID).Where(f => !f.OrderPickStatus.Equals(OrderStatus.Complete.ToString())).ToList();
                        int EmpOrderCount = LisEmpOrder.Count();
                        if (EmpOrderCount < 8)
                        {
                            objPicker = new Pickerorder();
                            objPicker.Company = order.Company;
                            objPicker.Ordernum = order.OrderNum;
                            //objPicker.Ordernum = itemhm.OrderNum;
                            objPicker.Orderdate = Convert.ToDateTime(order.OrderDate);
                            objPicker.Totalitems = order.TotalLines;
                            objPicker.Weight = order.TotalWgt_c;
                            objPicker.Dcduserid = pickerModel.DcdUserID;
                            objPicker.Pickdate = DateTime.Now;
                            objPicker.Pickstatus = "Pending";
                            objPicker.Recorddate = DateTime.Now;
                            objPicker.Recordupdatedon = DateTime.Now;
                            objPicker.Reasionpickfail = "NO";

                            // Order  Save
                            _DotitExtensionContext.Pickerorder.Add(objPicker);

                            pickorderdetail = new List<Pickorderdetail>();
                            // Order Detail Save
                            MapEpicorLinesAsync(order.OrderDtls, pickorderdetail);
                            _DotitExtensionContext.Pickorderdetail.AddRange(pickorderdetail);
                            PickerTotalLineItems += order.OrderDtls.Count();
                            pickerAssinedOrders += 1;
                            _DotitExtensionContext.SaveChanges();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            catch
            { }
        }



        public async Task<bool> AssignOrderToPickerAsync(PickerModel pickerModel)
        {
            // List<PickerModel> ListEmp = _pickerRepository.GetPickers(null, UserId).Where(x => Convert.ToDouble(x.MaxWeight) >= itemhm.TotalWgt_c).ToList();
            List<OrderHeadModel> dotItOrderList = null;
            Pickerorder objPicker = null;
            List<Pickorderdetail> pickorderdetail = null;
            List<OrderHeadModel> nccoOrderList = null;
            List<OrderHeadModel> dirfOrderList = null;

            try
            {

                dotItOrderList = _pickerRepository.GetDotItOrder().ToList();
                var epicorOrder = await OrdersReadyToPickAsync();
                epicorOrder = epicorOrder.Where(f => !dotItOrderList.Select(p => p.OrderNum).Contains(f.OrderNum)).ToList();
                nccoOrderList = epicorOrder.Where(f => f.Company.Equals("NCCO")).ToList();
                dirfOrderList = epicorOrder.Where(f => !f.CustNum.Equals("NCCO")).ToList();


                var dotItPickOrderList = dotItOrderList.Where(f => f.PickerUserId.Equals(pickerModel.DcdUserID) & !f.OrderPickStatus.Equals(OrderStatus.Complete.ToString()));
                int PickerTotalLineItems = dotItPickOrderList.Sum(f => f.TotalLines);
                int pickerAssinedOrders = pickerAssinedOrders = dotItPickOrderList.Count();

                foreach (OrderHeadModel order in dirfOrderList)
                {
                    //       if (pickerAssinedOrders + 1 > pickerModel.MaxOrder) return false;
                    if (pickerAssinedOrders + 1 < pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) return true;
                    if (PickerTotalLineItems < pickerModel.MaxLines && pickerAssinedOrders + 1 > pickerModel.MaxOrder) return true;
                    if (pickerAssinedOrders + 1 > pickerModel.MaxOrder && PickerTotalLineItems > pickerModel.MaxLines) return true;

                    objPicker = new Pickerorder();
                    objPicker.Company = order.Company;
                    objPicker.Ordernum = order.OrderNum;
                    //objPicker.Ordernum = itemhm.OrderNum;
                    objPicker.Orderdate = Convert.ToDateTime(order.OrderDate);
                    objPicker.Totalitems = order.TotalLines;
                    objPicker.Weight = order.TotalWgt_c;
                    objPicker.Dcduserid = pickerModel.DcdUserID;
                    objPicker.Pickdate = DateTime.Now;
                    objPicker.Pickstatus = "Pending";
                    objPicker.Recorddate = DateTime.Now;
                    objPicker.Recordupdatedon = DateTime.Now;
                    objPicker.Reasionpickfail = "NO";

                    // Order  Save
                    _DotitExtensionContext.Pickerorder.Add(objPicker);

                    pickorderdetail = new List<Pickorderdetail>();
                    // Order Detail Save
                    MapEpicorLinesAsync(order.OrderDtls, pickorderdetail);
                    _DotitExtensionContext.Pickorderdetail.AddRange(pickorderdetail);
                    PickerTotalLineItems += order.OrderDtls.Count();
                    pickerAssinedOrders += 1;
                    _DotitExtensionContext.SaveChanges();

                    pickorderdetail = null;
                }
            }
            catch (Exception ex)
            {
                // return false;
            }

            return true;
        }
        private async Task MapEpicorLinesAsync(List<OrderDetailModel> orderDtls, List<Pickorderdetail> pickorderdetail)
        {

            foreach (var item in orderDtls)
            {
                pickorderdetail.Add(new Pickorderdetail()
                {
                    Binnum = await _EpicorServiceApi.GetPartBinLocationAsync(item),
                    Company = item.Company,
                    Ordernum = item.OrderNum,
                    Partnum = item.PartNum,
                    Damageqty = 0,
                    Pickstatus = 6,
                    Orderline = item.OrderLine,
                    Orderqty = (decimal)item.OrderQty,
                    Ium = item.IUM,
                    Linedesc = item.LineDesc,
                    Unitprice = (decimal)item.UnitPrice,
                    Totalprice = (decimal)item.TotalPrice
                });
            }


        }
        public string Get8Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }
    }
}
