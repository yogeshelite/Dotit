//using System.IO;
using DotIt.AutoPicker.Data.DotIt;
using DotIt.AutoPicker.Data.Epicor;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Persistance.Repository;
using DotIt.AutoPicker.Service;
using DotIt.AutoPicker.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using EpicorDaily.Model;

namespace DotIt.AutoPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHeadModel> SaleOrderList;
        public static List<OrderDetailModel> LineItemList;
        public static List<PickerModel> PickersList;
        DotitExtensionContext DotitExtensionContext;
        EpicorServiceApi _epicorServiceApi;
        IPickerRepository _pickerRepository;
        private StackTrace _stackTrace;
       
        public PickerController(IHostingEnvironment hostingEnvironment, DotitExtensionContext dotItExtensionContext,EpicorServiceApi  epicorServiceApi)
        {
            _hostingEnvironment = hostingEnvironment;
            // _epicor10Context = epicor10Context;
            _stackTrace = new StackTrace();
            _pickerRepository = new PickerRepository(_stackTrace);
            _epicorServiceApi = epicorServiceApi;
            DotitExtensionContext = dotItExtensionContext;
        }
        public IActionResult Index()//this is our landing view string PickerDI
        {
            try
            {
              

                #region Picking for local db hare 
                var Picker = DotitExtensionContext.Warehouseemployee.ToList();
                ViewBag.Pickerddl = Picker.ToList();
                #endregion


            }
            catch
            {
                // return RedirectToAction("Index", "Picker");
            }
            return View();
        }

        public IActionResult Orders(string id)
        {
           
                SaleOrderList = null;
                SaleOrderList = GetDotitPickerOrders();
                ViewBag.OrderList = SaleOrderList;
          
            //if (id != null)
            //{

            //    #region /*Gobind*/ Sorting by picker by PickerId NCCO company or DIRF

            //    var dbpicker = _epicor10Context.UserFile.FirstOrDefault(x => x.DcdUserId == id);
            //    var warehouseemployee = DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Dcduserid == id);
            //    #endregion




            //    #region @Gobind 
            //    // SaleOrderList = SaleOrderList.Take(1000).ToList();
            //    if (dbpicker.CompList == "NCCO")
            //    {
            //        SaleOrderList = SaleOrderList.OrderBy(x => x.CustNum).Take(1000).ToList();
            //    }
            //    else
            //    {
            //        SaleOrderList = SaleOrderList.Where(Com => Com.CustNum != 1).Take(1000).ToList();
            //    }


            //    ViewBag.OrderList = SaleOrderList;
            //    #endregion

            //}
            //else
            //{

            //    #region Doing Becouse we don't have any kind of credential

            //    // GetTotalLineOfItems();
            //    ViewBag.OrderList = SaleOrderList.OrderBy(x => x.OrderNum).Take(1000);
            //    #endregion

            //    #region otherwise Show Error Or Login First

            //    #endregion

            //}


            return View();
        }
        //public void GetTotalLineOfItems()
        //{
        //    List<OrderHeadModel> _LocalSaleOrderList = new List<OrderHeadModel>();
        //    if (SaleOrderList != null && SaleOrderList.Count() > 0)
        //    {

        //        using (_apiResponse = new ApiResponse())
        //        {
        //            ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
        //            var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);

        //            if (OrderDetails.ContainsKey("value"))
        //            {

        //                if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
        //                {
        //                    var GetLineOfItems = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
        //                    foreach (var lineitems in SaleOrderList.OrderBy(x => x.OrderNum))
        //                    {
        //                        var _GetLineOfItems = GetLineOfItems.Where(x => x.OrderNum == lineitems.OrderNum);

        //                        //  lineitems.TotalLines = _GetLineOfItems.Count();
        //                        _LocalSaleOrderList.Add(lineitems);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    SaleOrderList = _LocalSaleOrderList;
        //}

        [HttpPost]
        public JsonResult PickLineItem()
        {
            string message = string.Empty;
            if (SaleOrderList != null)
            {
                message = "Orders Haved";
            }
            else
            {
                message = "First Click on Orders";

            }

            return Json(message);


        }
        public IActionResult Pick()
        {
            //int[] Ordernum = JsonConvert.DeserializeObject<int[]>(JsonConvert.DeserializeObject<Dictionary<string, object>>(Orders)["Data"].ToString());
            var User = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());
            // int[] Ordernum = JsonConvert.DeserializeObject<int[]>(JsonConvert.DeserializeObject<Dictionary<string, object>>(Orders)["Data"].ToString());
            int[] Ordernum = _pickerRepository.GetDotItOrder(null, User.DcdUserID).Where(f => !f.OrderPickStatus.Equals(OrderStatus.Complete)).Select(x => x.OrderNum).ToArray();


            #region do shorting in saleorderlist for Priority wise but we don't have order status
            if (SaleOrderList != null)
            {
                ViewBag.OrderLineItems = GetDotItOrderDetails(Ordernum, (int)LineItemStatus.Pending);
                if (ViewBag.OrderLineItems != null)
                {
                    //WriteToFileOrderProcessing(Ordernum, "Processing");
                }
                //Entry in log
                return View();

            }
            else
            {
                //Entry in log
                return RedirectToAction("Index", "Picker");
            }



            #endregion
        }
        public IActionResult AssignedOrderList()
        {
            //int[] Ordernum = JsonConvert.DeserializeObject<int[]>(JsonConvert.DeserializeObject<Dictionary<string, object>>(Orders)["Data"].ToString());
            var User = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());
            // int[] Ordernum = JsonConvert.DeserializeObject<int[]>(JsonConvert.DeserializeObject<Dictionary<string, object>>(Orders)["Data"].ToString());
            int[] Ordernum = _pickerRepository.GetDotItOrder(null, User.DcdUserID).Where(f => !f.OrderPickStatus.Equals(OrderStatus.Complete)).Select(x => x.OrderNum).ToArray();


            #region do shorting in saleorderlist for Priority wise but we don't have order status
            if (SaleOrderList != null)
            {
                ViewBag.OrderLineItems = GetDotItOrderDetails(Ordernum);
                if (ViewBag.OrderLineItems != null)
                {
                    //WriteToFileOrderProcessing(Ordernum, "Processing");
                }
                //Entry in log
                return View();

            }
            else
            {
                //Entry in log
                return RedirectToAction("Index", "Picker");
            }



            #endregion
        }


        public List<OrderHeadModel> GetDotitPickerOrders()//This is a method 
        {
            List<OrderHeadModel> orderlist = null;
            try
            {
                var UserLogInName = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());

                if (UserLogInName != null)
                {
                    PickerModel objmodel = UserLogInName;
                    var UserId = objmodel.DcdUserID;
                    orderlist = _pickerRepository.GetDotItOrder(null, UserId).Where(f => !f.OrderPickStatus.Equals(OrderStatus.Complete)).ToList();
                    //if (SaleOrderList == null || SaleOrderList.Count() == 0)
                    //    GetEpicorOrders();
                    // JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderList["value"].ToString());
                    foreach (var _Order in orderlist)
                    {
                        _Order.OrderDateTime = Convert.ToDateTime(_Order.OrderDate);

                    }


                    orderlist.Where(o => o.OrderDateTime < (DateTime.Now)).OrderByDescending(o => o.RequestDate).ToList();
                }
            }
            catch
            {
                RedirectToAction("Error", "Home");
            }
            return orderlist;
        }


        

      
        public async Task< List<OrderDetailModel>> GetDotItOrderDetails(int[] Orders, int statuscode = 0)
        {
            var _result=  _pickerRepository.GetDotItOrderDetails(Orders, null, statuscode).OrderBy(f => f.BinNum).ToList();
            foreach (var item in _result)
            {
                 item.ImageContent = await _epicorServiceApi.GetItemImageByPartNumberAsync(item.PartNum);
            }
            return _result;
        }


        public JsonResult PickLineItems(int ordernum, int orderline, string status, string partno, string binno)
        {
            string msg = string.Empty;
            string PartNum = partno;
            string BinNum = binno;
            var Order = SaleOrderList.Where(o => o.OrderNum == ordernum).Single();
            // var Orderlist = LineItemList.Where(o => o.OrderNum == ordernum).FirstOrDefault();
            Pickerorder model = null;
            // var list = _pickerRepository.GetDotItOrder(); //DotitExtensionContext.Pickerorder.ToList();
            //Order.TotalLines = orderline;
            //Order.PickDate = DateTime.Now;

            if (status == LineItemStatus.Picked.ToString())
            {
                _pickerRepository.DotitOrderPickerUpdate(ordernum, LineItemStatus.Picked.ToString(), "NO", partno, (int)LineItemStatus.Picked);
                //var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderLine == orderline).Single().OrderPickStatus = "Processing";
                msg = orderline + " LineItem is Picked";
            }
            if (status == LineItemStatus.UnPicked.ToString())
            {
                _pickerRepository.DotitOrderPickerUpdate(ordernum, LineItemStatus.UnPicked.ToString(), "NO", partno, (int)LineItemStatus.UnPicked);
                //var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderLine == orderline).Single().OrderPickStatus = null;
                msg = orderline + " LineItem is UnPicked";
            }
            #region status order in Quarentine (Hold)
            if (status == LineItemStatus.Quarentine.ToString())
            {

                _pickerRepository.DotitOrderPickerUpdate(ordernum, OrderStatus.Hold.ToString(), "NO", partno, (int)LineItemStatus.Quarentine);
                //model = _pickerRepository.GetDotItOrder().FirstOrDefault(f => f.OrderNum == ordernum);
                ////DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);

                //if (model != null)
                //{
                //    model.OrderPickStatus = Status.Hold.ToString();
                //    model.ReasionPickFail = string.Format(" Part# {0} in bin location {1} has been quarentine,'" + Orderlist.PartNum + "','" + Orderlist.BinNum + "'");
                //    DotitExtensionContext.SaveChanges();
                //}

            }
            #endregion

            if (status == LineItemStatus.Replenish.ToString())
            {

                _pickerRepository.DotitOrderPickerUpdate(ordernum, LineItemStatus.Replenish.ToString(), "NO", partno, (int)LineItemStatus.Replenish);
                //hare we sent the email to stave for Replenish
                // var pickOrder = DotitExtensionContext.Pickerorder.FirstOrDefault();

                //    model = DotitExtensionContext.Pickerorder.FirstOrDefault(x => x.Ordernum == ordernum);
                //if (model != null)
                //{
                //    model.Pickstatus = Status.Picked.ToString();
                //    DotitExtensionContext.SaveChanges();
                //}

            }
            if (status == LineItemStatus.InventoryControl.ToString())
            {
                String ResionPickFail = string.Format(" Part# {0} in bin location {1} has been InventoryControl,'" + PartNum + "','" + BinNum + "'", PartNum, BinNum);
                _pickerRepository.DotitOrderPickerUpdate(ordernum, OrderStatus.Hold.ToString(), ResionPickFail, partno, (int)LineItemStatus.InventoryControl);
                //hare we sent the email to stave for InventoryControl
                //model = DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);

                //if (model != null)
                //{
                //    model.Pickstatus = Status.Hold.ToString();
                //    model.ReasionPickFail = string.Format(" Part# {0} in bin location {1} has been InventoryControl,'" + Orderlist.PartNum + "','" + Orderlist.BinNum + "'");
                //    DotitExtensionContext.SaveChanges();
                //}

            }
            //new DotitOrderCsv(_hostingEnvironment).WriteToFile(Order, "pick");
            var orderstatus = OrderCompleteOrNot(ordernum);

            if (orderstatus != "Completed")
            {
                return Json(msg);
            }
            else
            {
                #region status order Picked

                //model = DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);
                //if (model != null)
                //{
                //    model.Pickstatus = Status.Picked.ToString();
                //    DotitExtensionContext.SaveChanges();
                //}
                #endregion

                #region
                //DotitExtensionContext.Entry(model).State = EntityState.Modified;
                //        _dotItPickerContext.SaveChanges();

                //var _list = list.FirstOrDefault(x => x.Ordernum == ordernum).Pickstatus = Status.Picked.ToString();

                //#region code for remove from local list
                ////LineItemList.RemoveAt();
                ////LineItemList.Remove(Orderno1);
                //#endregion
                #endregion

                //var _LineItemList = LineItemList;
                return Json("Completed");
            }
        }

        public string OrderCompleteOrNot(int ordernum)
        {

            List<OrderHeadModel> pickedOrders = _pickerRepository.GetDotItOrderByOrderNo(OrderStatus.Complete.ToString(), ordernum).ToList();
            string orderstatus = string.Empty;
            Pickerorder objPickerOrderUpdate = DotitExtensionContext.Pickerorder.FirstOrDefault(x => x.Ordernum == ordernum);
            if (objPickerOrderUpdate != null)
            {
                var pendingPicklinecount = _pickerRepository.GetDotItOrderDetails(new int[1] { ordernum }, null, (int)LineItemStatus.Pending).Count();
                if (pendingPicklinecount == 0)
                {

                    objPickerOrderUpdate.Pickstatus = OrderStatus.Complete.ToString();
                    DotitExtensionContext.SaveChanges();
                    orderstatus = "Completed";
                }
                else
                {
                    orderstatus = "Not Completed";
                }
            }

            //var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderPickStatus != "Processing".ToString()).ToList();

            //if (updatelist.Count > 0)
            //{
            //    orderstatus = "Not Completed";

            //}
            //else
            //{
            //    new DotitOrderCsv(_hostingEnvironment).WriteToFileOrderStatus(ordernum, "Completed");
            //    //var completeorder = LineItemList.Find(o => o.OrderNum == ordernum);
            //    //LineItemList.Remove(completeorder);

            //    orderstatus = "Completed";

            //}
            return orderstatus;
        }

        public IActionResult CompleteOrder(string ordernumber)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ordernumber)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNum).Single())).OrderPickStatus = "Completed";
            ViewBag.OrderList = SaleOrderList;
            return View("Index");
        }

        public IActionResult MoveToQuarantine(string ordernumber)
        {
            int OrderNumber = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ordernumber)));
            var Order = SaleOrderList.Where(o => o.OrderNum == OrderNumber).Single();
            Order.PickDate = DateTime.Now;
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNumber).Single())).OrderPickStatus = "Quarantined";
            //WriteToFile(Order, "quarantine");

            ViewBag.OrderLineItems = SaleOrderList;// GetDotItOrderDetails(Orders: new int[]{ OrderNumber }); //GetOrderDetails(new string[] { ordernumber }).Where(x => x.OrderNum != OrderNumber);
            return View("Pick");
        }

        public IActionResult Profile(int id)
        {
            //var AllPickers = _dotItPickerContext.Warehouseemployee.FromSql("GetEmployees").ToList();
            //var model = AllPickers.FirstOrDefault(x => x.Empid == id);
            //return View(model);
            return View();
        }
        public async Task<IActionResult> AssignOrderPickerAsync()
        {
            OrderAssignPicker obj = new OrderAssignPicker(_hostingEnvironment, DotitExtensionContext, _epicorServiceApi);
            //  List<OrderHeadModel> list = obj.OrdersReadyToPick();

            //obj.GetEpicoreOrder();

            var User = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());

            if (User != null)
            {
                PickerModel objpicker = User;
                bool response = await obj.AssignOrderToPickerAsync(objpicker);
                if (response == true)
                {
                    return RedirectToAction("Orders");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        //[HttpPost]
        //public ActionResult ProfileChanges(Warehouseemployee model)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        _dotItPickerContext.Entry(model).State = EntityState.Modified;
        //        _dotItPickerContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View("Index");
        //}
    }
}