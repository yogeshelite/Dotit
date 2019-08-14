using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using DotIt.AutoPicker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using DotIt.AutoPicker.Data;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
//using System.IO;
using System.Text;
using CsvFileReader;
using static DotIt.AutoPicker.Models.Enums;
using DotIt.AutoPicker.Data.Epicor;
using DotIt.AutoPicker.Data.DotIt;
using DotIt.AutoPicker.Persistance.Repository;
using DotIt.AutoPicker.Service;
//using EpicorDaily.Model;

namespace DotIt.AutoPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHeadModel> SaleOrderList;
        public static List<OrderDetailModel> LineItemList;
        public static List<PickerModel> PickersList;
        // public static List<FileStore> FileStoreList;
        Erp102TestContext _epicor10Context;
        //DotItPickerContext _dotItPickerContext;
        DotitExtensionContext DotitExtensionContext;
        IPickerRepository _pickerRepository;
        ApiResponse _apiResponse;
        private StackTrace _stackTrace;
        //public PickerController(IHostingEnvironment hostingEnvironment, DotItPickerContext dotItPickerContext, Epicor10Context epicor10Context)
        //{
        //    _hostingEnvironment = hostingEnvironment;
        //    _epicor10Context = epicor10Context;

        //    _dotItPickerContext = dotItPickerContext;
        //}
        public PickerController(IHostingEnvironment hostingEnvironment, DotitExtensionContext dotItExtensionContext, Erp102TestContext epicor10Context)
        {
            _hostingEnvironment = hostingEnvironment;
            _epicor10Context = epicor10Context;
            _stackTrace = new StackTrace();
            _pickerRepository = new PickerRepository(_stackTrace);
            DotitExtensionContext = dotItExtensionContext;
        }
        public IActionResult Index()//this is our landing view string PickerDI
        {
            try
            {
                // dbcs = new Epicor10Context();
                //var dbpicker = dbcs.UserFile.ToList();

                #region for Picking pickers EmpId we used this query  but where is emp id

                //var  user = (from uf in cs.UserFiles where uf.DcdUserID == pUserId && uf.UserDisabled == false select uf).Single();

                //select eb.Company, eb.EmpID, eb.FirstName, eb.LastName,
                //eb.name, eb.DcdUserID from erp.empbasic as eb
                #endregion

                #region Picking for local db hare 
                var Picker = DotitExtensionContext.Warehouseemployee.ToList();
                ViewBag.Pickerddl = Picker.ToList();
                //var picker = _dotItPickerContext.Warehouseemployee.FromSql("GetEmployees").ToList();//hare we geting all pickers in local db
                //ViewBag.Pickerddl = picker.ToList();

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
            if (SaleOrderList == null || SaleOrderList.Count()==0)
            {
                GetOrders();
            }
            if (id != null)
            {

                #region /*Gobind*/ Sorting by picker by PickerId NCCO company or DIRF

                var dbpicker = _epicor10Context.UserFile.FirstOrDefault(x => x.DcdUserId == id);
                var warehouseemployee = DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Dcduserid == id);
                #endregion

               


                #region @Gobind 
               // SaleOrderList = SaleOrderList.Take(1000).ToList();
                if (dbpicker.CompList == "NCCO")
                {
                    SaleOrderList = SaleOrderList.OrderBy(x => x.CustNum).Take(1000).ToList();
                }
                else
                {
                    SaleOrderList = SaleOrderList.Where(Com => Com.CustNum != 1).Take(1000).ToList();
                }


                ViewBag.OrderList = SaleOrderList;
                #endregion

            }
            else
            {

                #region Doing Becouse we don't have any kind of credential
              
               // GetTotalLineOfItems();
                ViewBag.OrderList = SaleOrderList.OrderBy(x => x.OrderNum).Take(1000);
                #endregion

                #region otherwise Show Error Or Login First

                #endregion

            }


            return View();
        }
        public void GetTotalLineOfItems()
        {
            List<OrderHeadModel> _LocalSaleOrderList = new List<OrderHeadModel>();
            if (SaleOrderList != null && SaleOrderList.Count()>0)
            {

                using (_apiResponse = new ApiResponse())
                {
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
                    var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);

                    if (OrderDetails.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                        {
                            var GetLineOfItems = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
                            foreach (var lineitems in SaleOrderList.OrderBy(x => x.OrderNum))
                            {
                                var _GetLineOfItems = GetLineOfItems.Where(x => x.OrderNum == lineitems.OrderNum);

                                lineitems.TotalLines = _GetLineOfItems.Count();
                                _LocalSaleOrderList.Add(lineitems);
                            }
                        }
                    }
                }
            }
            SaleOrderList = _LocalSaleOrderList;
        }

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
        public IActionResult Pick(string Orders)
        {
            string[] Ordernum = JsonConvert.DeserializeObject<string[]>(JsonConvert.DeserializeObject<Dictionary<string, object>>(Orders)["Data"].ToString());
            #region do shorting in saleorderlist for Priority wise but we don't have order status
            if (SaleOrderList != null)
            {
                ViewBag.OrderLineItems = GetOrderDetails(Ordernum);
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

        public void GetEpicorOrders()
        {
            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "GET");
                    var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                    if (OrderList.ContainsKey("value"))
                    {
                        if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                        {
                            SaleOrderList = JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderList["value"].ToString());
                            foreach (var _Order in SaleOrderList)
                            {
                                _Order.OrderDateTime = Convert.ToDateTime(_Order.OrderDate);

                            }
                            SaleOrderList = SaleOrderList.Where(o => o.OrderDateTime < (DateTime.Now)).OrderBy(o => o.OrderDateTime).ToList();
                        }
                    }
                }
            }
            catch
            {
                RedirectToAction("Error", "Home");
            }


        }

        public void GetOrders()//This is a method 
        {
            try
            {
                SaleOrderList = _pickerRepository.GetDotItOrder();
                if (SaleOrderList == null || SaleOrderList.Count() == 0) GetEpicorOrders();
                // JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderList["value"].ToString());
                foreach (var _Order in SaleOrderList)
                {
                    _Order.OrderDateTime = Convert.ToDateTime(_Order.OrderDate);

                }
               

                SaleOrderList = SaleOrderList.Where(o => o.OrderDateTime < (DateTime.Now)).OrderBy(o => o.OrderDateTime).ToList();
            }
            catch
            {
                RedirectToAction("Error", "Home");
            }
        }


        public string GetItemImageByPartNumber(string PartNumber)
        {

            var image = _epicor10Context.Part.Join(_epicor10Context.Image, p => new { p.Company, p.ImageId }, i => new { i.Company, i.ImageId }, (p, i) => new { p, i }).Join(_epicor10Context.FileStore, pi => new { pi.p.Company, pi.i.ImageSysRowId }, fl => new { Company = fl.Company, ImageSysRowId = fl.SysRowId }, (pi, fl) => new { PartNumber = pi.p.PartNum, Content = fl.Content }).FirstOrDefault(f => f.PartNumber == PartNumber);
            return (image != null && image.Content.LongCount() > 0) ? string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(image.Content)) : "img/bg-showcase-2.jpg";


        }

        public List<OrderDetailModel> GetOrderDetails(string[] Orders)
        {
            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                var _result = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
                                if (_result != null) _result = _result.Where(x => Orders.Contains(x.OrderNum.ToString())).ToList();

                                ResponseModel _PObjResponse = null;
                                Dictionary<string, object> Objbinnum = null;
                                Dictionary<string, object> retobj = null;

                                string empty = string.Empty;

                                foreach (var _Order in _result)
                                {
                                    GetPartBinLocation(_PObjResponse, Objbinnum, retobj, _Order);
                                    //_Order.ImageContent = GetItemImageByPartNumber(_Order.PartNum);
                                }
                                LineItemList = _result;
                                return _result;
                            }
                        }
                    }
                    else
                    {
                        RedirectToAction("Error", "Home");
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.Message.ToString();
                }
            }
            return null;
        }

        private void GetPartBinLocation(ResponseModel _PObjResponse, Dictionary<string, object> Objbinnum, Dictionary<string, object> retobj, OrderDetailModel _Order)
        {
            _PObjResponse = _apiResponse.GetApiResponse(Constant.PartBinSearchSvc, "POST", "{\"partNum\":'" + _Order.PartNum + "',\"whseCode\":''}");
            if (_PObjResponse.success)
            {
                Objbinnum = JsonConvert.DeserializeObject<Dictionary<string, object>>(_PObjResponse.Response);

                //var _resultbinnum1 = JsonConvert.DeserializeObject<List<OrderDetModel>>(_PObjResponse.Response);
                if (Objbinnum.ContainsKey("returnObj"))
                {
                    if (!String.IsNullOrEmpty(Objbinnum["returnObj"].ToString()))
                    {
                        retobj = JsonConvert.DeserializeObject<Dictionary<string, object>>(Objbinnum["returnObj"].ToString());
                        if (retobj.ContainsKey("PartBinSearch"))
                        {
                            var partBinList = JsonConvert.DeserializeObject<List<OrderDetailModel>>(retobj["PartBinSearch"].ToString()).Select(f => new { BinNum = f.BinNum, BinDesc = f.BinDesc, BinType = f.BinType }).FirstOrDefault();
                            if (partBinList != null)
                            {
                                _Order.BinNum = partBinList.BinNum;
                                _Order.BinDesc = partBinList.BinDesc;
                                _Order.BinType = partBinList.BinType;
                            }
                        }
                    }
                }
            }
        }

        public JsonResult PickLineItems(int ordernum, int orderline, string status)
        {
            string msg = string.Empty;
            var Order = SaleOrderList.Where(o => o.OrderNum == ordernum).Single();
            var Orderlist = LineItemList.Where(o => o.OrderNum == ordernum).FirstOrDefault();
            Pickerorder  model = null;
            var list = _pickerRepository.GetDotItOrder(); //DotitExtensionContext.Pickerorder.ToList();
            Order.TotalLines = orderline;
            Order.PickDate = DateTime.Now;

            if (status == Status.Picked.ToString())
            {
                var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderLine == orderline).Single().OrderPickStatus = "Processing";
                msg = orderline + " LineItem is Picked";
            }
            if (status == Status.UnPicked.ToString())
            {
                var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderLine == orderline).Single().OrderPickStatus = null;
                msg = orderline + " LineItem is UnPicked";
            }
            #region status order in Quarentine (Hold)
            if (status == Status.Quarentine.ToString())
            {


                //model = _pickerRepository.GetDotItOrder().FirstOrDefault(f => f.OrderNum == ordernum);
                //    //DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);

                //if (model != null)
                //{
                //    model.OrderPickStatus = Status.Hold.ToString();
                //    model.ReasionPickFail = string.Format(" Part# {0} in bin location {1} has been quarentine,'" + Orderlist.PartNum + "','" + Orderlist.BinNum + "'");
                //    DotitExtensionContext.SaveChanges();
                //}

            }
            #endregion

            if (status == Status.Replenish.ToString())
            {

                //hare we sent the email to stave for Replenish
                model = DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);
                if (model != null)
                {
                    model.Pickstatus = Status.Picked.ToString();
                    DotitExtensionContext.SaveChanges();
                }

            }
            if (status == Status.InventoryControl.ToString())
            {
                //hare we sent the email to stave for InventoryControl
                model = DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);

                if (model != null)
                {
                    model.Pickstatus = Status.Hold.ToString();
                    model.ReasionPickFail = string.Format(" Part# {0} in bin location {1} has been InventoryControl,'" + Orderlist.PartNum + "','" + Orderlist.BinNum + "'");
                    DotitExtensionContext.SaveChanges();
                }

            }
            new DotitOrderCsv(_hostingEnvironment).WriteToFile(Order, "pick");
            var orderstatus = OrderCompleteOrNot(ordernum);

            if (orderstatus != "Completed")
            {
                return Json(msg);
            }
            else
            {
                #region status order Picked

                model = DotitExtensionContext.Pickerorder.SingleOrDefault(x => x.Ordernum == ordernum);
                if (model != null)
                {
                    model.Pickstatus = Status.Picked.ToString();
                    DotitExtensionContext.SaveChanges();
                }
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

                var _LineItemList = LineItemList;
                return Json("Completed");
            }
        }

        public string OrderCompleteOrNot(int ordernum)
        {
            string orderstatus = string.Empty;
            var updatelist = LineItemList.Where(o => o.OrderNum == ordernum && o.OrderPickStatus != "Processing".ToString()).ToList();

            if (updatelist.Count > 0)
            {
                orderstatus = "Not Completed";

            }
            else
            {
                new DotitOrderCsv(_hostingEnvironment).WriteToFileOrderStatus(ordernum, "Completed");
                //var completeorder = LineItemList.Find(o => o.OrderNum == ordernum);
                //LineItemList.Remove(completeorder);

                orderstatus = "Completed";

            }
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

            ViewBag.OrderLineItems = GetOrderDetails(new string[] { ordernumber }).Where(x => x.OrderNum != OrderNumber);
            return View("Pick");
        }

        public IActionResult Profile(int id)
        {
            //var AllPickers = _dotItPickerContext.Warehouseemployee.FromSql("GetEmployees").ToList();
            //var model = AllPickers.FirstOrDefault(x => x.Empid == id);
            //return View(model);
            return View();
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