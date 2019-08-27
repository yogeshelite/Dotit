using DotIt.AutoPicker.Data.DotIt;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Persistance.Repository;
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
    public class OrderAssignPicker
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly DotitExtensionContext _DotitExtensionContext;
        private readonly IPickerRepository _pickerRepository;
        List<OrderDetailModel> OrderDetails =null;
       
        private StackTrace _stackTrace;

        public static bool allowaccess = false;
        ApiResponse _apiResponse;

        public OrderAssignPicker(IHostingEnvironment hostingEnvironment, DotitExtensionContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _DotitExtensionContext = context;
            _stackTrace = new StackTrace();
            _pickerRepository = new PickerRepository(_stackTrace);
        }
        private List<OrderHeadModel> GetEpicoreOrder()
        {
            List<OrderHeadModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrderFilter, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                List<OrderHeadModel> _result = JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderDetails["value"].ToString());
                                if (_result != null)
                                {


                                    _result = _result.ToList();

                                     resultOrderList = _result.Where(x => x.OpenOrder == true && Convert.ToDateTime(string.Format("{0:MM/dd/yyyy}", x.OrderDate)) <DateTime.Now)
                                                                    .ToList();
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
        private List<OrderDetailModel> GetOrderDetails()
        {
            List<OrderDetailModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetailsFilter, "GET");
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
        public List<PartBinModel> GetPartBin(string partnum)
        {
            List<PartBinModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    var databody = "{ \"PageSize\": \"0\",\"AbsolutePage\": \"0\",\"whereClause\": \"PartNum\"='"+partnum+"'\"}";
                    var input = new
                    {
                        PageSize = 0,
                        AbsolutePage = 0,
                        whereClause = "PartNum='"+ partnum + "'"
                    };
                    string inputJson = JsonConvert.SerializeObject(input);
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_PartBinSearch, "post", inputJson);
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("returnObj"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["returnObj"].ToString()))
                            {
                                var _resultReturnObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(OrderDetails["returnObj"].ToString());
                                if (_resultReturnObj != null)
                                {
                                    resultOrderList = JsonConvert.DeserializeObject<List<PartBinModel>>(_resultReturnObj["PartBinSearch"].ToString());

                                    //_result = _result.ToList();

                                    //resultOrderList = _result.Where(x => x.OpenOrder == true && x.TotalWgt_c > 0)
                                    //                               .ToList();
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
        public List<PartsModel> GetParts()
        {
            List<PartsModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_Parts, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                List<PartsModel> _result = JsonConvert.DeserializeObject<List<PartsModel>>(OrderDetails["value"].ToString());
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
        public List<OrderHeadModel> OrdersReadyToPick(Int32 maxLines = 50, Decimal maxWeight = 150.0m, Boolean dotit = true, Boolean ncco = false)
        {
           // DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
            Int32 totalLines = 0;
            Decimal totalWeight = 0.0m;
            List<OrderHeadModel> listLines = new List<OrderHeadModel>();
            //List<Int32> orderSelected = new List<Int32>();

            var rsPotentialOrders = GetEpicoreOrder();

            String abc4 = "pause";
            OrderDetails = GetOrderDetails();
            foreach (OrderHeadModel queue in rsPotentialOrders)
            {
                if (queue.CustNum == 1 && ncco == false)
                {
                   // DLog.Log("Skipping order: " + queue.OrderNum + " as picker is not assigned to NCCO orders");
                    continue;
                }

                if (queue.CustNum != 1 && dotit == false)
                {
                   // DLog.Log("Skipping order: " + queue.orderNum + " as picker is not assigned to non NCCO orders");
                    continue;
                }

                //  Test to see if the order can be shipped complete.
                if (!IsOrderComplete(queue.OrderNum))
                {
                    //DLog.Log("Skipping Order: " + queue.orderNum + " due to lines not having enough inventory.");
                    continue;
                }

                //  How many lines is this order
                totalLines += (from od in OrderDetails where od.OrderNum == queue.OrderNum && od.OpenLine == true select od).Count();

                //  If puts over max, then bail with orders
                if (maxLines < totalLines)
                {
                   // DLog.Log("Cutting off line assignment due to maxLine: " + maxLines + " exceeding totalLines: " + totalLines);
                    break;
                }

                Decimal orderWeight = CalculateWeightOpenLines(queue.OrderNum);

                if (orderWeight <= 0.0m)
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
                q.TotalLines = totalLines;
                q.TotalWgt_c = (double)totalWeight;

                listLines.Add(q);
            }

            String svn = "wait";
            return listLines;
        }


        private  Boolean IsOrderComplete(Int32 orderNum)
        {
            //DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

            try
            {

                List<OrderDetailModel> lines = (from od in OrderDetails where od.OrderNum == orderNum && od.OpenLine == true select od).ToList<OrderDetailModel>();
                Boolean isComplete = true;

                foreach (OrderDetailModel line in lines)
                {
                    List<PartBinModel> PartBins = GetPartBin(line.PartNum);
                    var bins = from pb in PartBins where pb.PartNum == line.PartNum && pb.WhseCode == "Main" select pb;
                    Decimal qtyOnHand = 0.0m;

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


        private  Decimal CalculateWeightOpenLines(Int32 orderNum)
        {
            //DLog.StartModule();

            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
            List<PartsModel> Parts = GetParts();
            Decimal weight = 0.0m;

            try
            {
                List<OrderDetailModel> lines = (from od in OrderDetails where od.OrderNum == orderNum && od.OpenLine == true select od).ToList<OrderDetailModel>();

                foreach (OrderDetailModel line in lines)
                {
                    Decimal itemWeight = (from p in Parts where p.PartNum == line.PartNum select p.GrossWeight).Single();
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
        public void assignOrder() {

            //  List<OrderHeadModel> OrderList = OrdersReadyToPick();
            //List Of OrderHead
            List<OrderHeadModel> OrderList = new List<OrderHeadModel>();
            OrderHeadModel objClsHM = new OrderHeadModel();
            objClsHM.Company = "DIRF";
            objClsHM.OrderNum = Convert.ToInt32(DateTime.Now.ToString("MMddHHmmss")); 
            objClsHM.OrderDate ="2019-08-26";
            objClsHM.TotalLines =6;
            objClsHM.Weight = 10;
            objClsHM.TotalWgt_c = 10;
            objClsHM.PickDate = DateTime.Now;
            //objClsHM.Pickstatus = "Pending";
            objClsHM.RequestDate = DateTime.Now;
            OrderList.Add(objClsHM);
            // List Of OrderDetails
            //List<Pickorderdetail> ListOrderDetail = new List<Pickorderdetail>();
            //Pickorderdetail objOrderDetail = new Pickorderdetail();
            //objOrderDetail.Orderno = 0;
            //objOrderDetail.Company = "DIRF";
            //objOrderDetail.Partnum = "";
            //objOrderDetail.Binnum = "";
            //objOrderDetail.Damageqty = 0;
            //objOrderDetail.Pickstatus = 1;
            //ListOrderDetail.Add(objOrderDetail);


            foreach (OrderHeadModel itemhm in OrderList)
            {
                List<PickerModel> ListEmp = _pickerRepository.GetPickers().Where(x=>Convert.ToDouble(x.MaxWeight) >=itemhm.TotalWgt_c ).ToList();
                foreach (PickerModel itempm in ListEmp)
                {
                    Pickerorder objPicker = new Pickerorder();
                    int orderno= Convert.ToInt32(Get8Digits());
                    objPicker.Company = itemhm.Company;
                    objPicker.Ordernum = orderno;
                    //objPicker.Ordernum = itemhm.OrderNum;
                    objPicker.Orderdate = Convert.ToDateTime(itemhm.OrderDate);
                    objPicker.Totalitems = itemhm.TotalLines;
                    objPicker.Weight = itemhm.TotalWgt_c;
                    objPicker.Dcduserid = itempm.DcdUserID;
                    objPicker.PickDate = DateTime.Now;
                    objPicker.Pickstatus = "Pending";
                    objPicker.Recorddate = DateTime.Now;
                    objPicker.Recordupdatedon = DateTime.Now;
                    objPicker.ReasionPickFail = "NO";
                    _DotitExtensionContext.Pickerorder.Add(objPicker);
                    _DotitExtensionContext.SaveChanges();

                    Pickorderdetail objOrderDetail = new Pickorderdetail();
                    objOrderDetail.Orderno = orderno;
                    objOrderDetail.Company = "DIRF";
                    objOrderDetail.Partnum = "Partnum"+ orderno;
                    objOrderDetail.Binnum = "Bin"+ orderno;
                    objOrderDetail.Damageqty = 0;
                    objOrderDetail.Pickstatus = 1;
                    objOrderDetail.OrderLine = 1;
                    objOrderDetail.OrderQty = 1;
                    objOrderDetail.IUM = "PK";
                    objOrderDetail.LineDesc ="Item 1";
                    objOrderDetail.UnitPrice = 6;
                    objOrderDetail.TotalPrice = 6;

                    _DotitExtensionContext.Pickorderdetail.Add(objOrderDetail);
                    _DotitExtensionContext.SaveChanges();
                }
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
