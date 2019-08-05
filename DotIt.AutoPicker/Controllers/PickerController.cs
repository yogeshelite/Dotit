﻿using System;
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

namespace DotIt.AutoPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHedModel> SaleOrderList;
        public static List<OrderDetModel> LineItemList;
        public static List<PickersModel> PickersList;
        public static List<FileStore> FileStoreList;
        Epicor10Context _epicor10Context;
        //DotItPickerContext _dotItPickerContext;
        DotitExtensionContext DotitExtensionContext;
        ApiResponse _apiResponse;
        //public PickerController(IHostingEnvironment hostingEnvironment, DotItPickerContext dotItPickerContext, Epicor10Context epicor10Context)
        //{
        //    _hostingEnvironment = hostingEnvironment;
        //    _epicor10Context = epicor10Context;

        //    _dotItPickerContext = dotItPickerContext;
        //}
        public PickerController(IHostingEnvironment hostingEnvironment, DotitExtensionContext dotItExtensionContext, Epicor10Context epicor10Context)
        {
            _hostingEnvironment = hostingEnvironment;
            _epicor10Context = epicor10Context;

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
            if (id != null)
            {

                #region /*Gobind*/ Sorting by picker by PickerId NCCO company or DIRF
                var dbpicker = _epicor10Context.UserFile.FirstOrDefault(x => x.DcdUserID == id);
                #endregion

                if (SaleOrderList == null)
                {
                    GetOrders();
                }


                #region @Gobind 
                SaleOrderList = SaleOrderList.Take(1000).ToList();
                if (dbpicker.CompList == "NCCO")
                {
                    SaleOrderList = SaleOrderList.OrderBy(x => x.CustNum).Take(1000).ToList();
                }
                else
                {
                    SaleOrderList = SaleOrderList.Where(Com => Com.CustNum != 1).Take(1000).ToList();
                }
                #region for not repeting order for next picker need picker userid
                //List<OrderHedModel> LocalSaleOrderList = new List<OrderHedModel>();
                //var CsvordernumlistFrom = ReadOrderProcessing();
                //foreach (var _CsvordernumlistFrom in CsvordernumlistFrom)
                //{
                //    LocalSaleOrderList = SaleOrderList.Where(Com => Com.OrderNum != _CsvordernumlistFrom[0]).Take(1000).ToList();
                //}
                #endregion

                ViewBag.OrderList = SaleOrderList;
                #endregion

            }
            else
            {

                #region Doing Becouse we don't have any kind of credential
                if (SaleOrderList == null)
                {
                    GetOrders();
                }
                GetTotalLineOfItems();
                ViewBag.OrderList = SaleOrderList.OrderBy(x => x.OrderNum).Take(1000);
                #endregion

                #region otherwise Show Error Or Login First

                #endregion

            }


            return View();
        }
        public void GetTotalLineOfItems()
        {
            List<OrderHedModel> _LocalSaleOrderList = new List<OrderHedModel>();
            if (SaleOrderList != null)
            {

                using (_apiResponse = new ApiResponse())
                {
                    ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
                    var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);

                    if (OrderDetails.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                        {
                            var GetLineOfItems = JsonConvert.DeserializeObject<List<OrderDetModel>>(OrderDetails["value"].ToString());
                            foreach (var lineitems in SaleOrderList.OrderBy(x => x.OrderNum))
                            {
                                var _GetLineOfItems = GetLineOfItems.Where(x => x.OrderNum == lineitems.OrderNum);

                                lineitems.OrderLine = _GetLineOfItems.Count().ToString();
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
                    WriteToFileOrderProcessing(Ordernum, "Processing");
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

        public void GetOrders()//This is a method 
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
                            SaleOrderList = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderList["value"].ToString());
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

        public string GetItemImageByPartNumber(string PartNumber)
        {


            //var content = (from p in _epicor10Context.Part
            //              from i in _epicor10Context.Image
            //              from fl in _epicor10Context.FileStore
            //              where (new string[] { i.Company, fl.Company }.Contains(p.Company) & p.ImageId.Equals(i.ImageId))
            //              & fl.SysRowId.Equals(i.ImageSysRowId)
            //              & p.PartNum.Equals(PartNumber)
            //              select fl.Content).FirstOrDefault() ;


            // var image = _epicor10Context.FileStore.Join(_epicor10Context.Image, fl => new { Company = fl.Company, ImageSysRowId = fl.SysRowId }, i => new { i.Company, i.ImageSysRowId }, (fl, i) => new { fl }).Join(_epicor10Context.Part, fl => new { fl.fl.Company, fl.fl.SysRowId }, p => new { p.Company, p.SysRowId }, (fl, p) => new { image = fl.fl.Content, partNum = p.PartNum }).FirstOrDefault(f => f.partNum.Equals(PartNumber));
            var image = _epicor10Context.Part.Join(_epicor10Context.Image, p => new { p.Company, p.ImageId }, i => new { i.Company, i.ImageId }, (p, i) => new { p, i }).Join(_epicor10Context.FileStore, pi => new { pi.p.Company, pi.i.ImageSysRowId }, fl => new { Company = fl.Company, ImageSysRowId = fl.SysRowId }, (pi, fl) => new { PartNumber = pi.p.PartNum, Content = fl.Content }).FirstOrDefault(f => f.PartNumber.Equals(PartNumber));

            return (image != null && image.Content.LongCount() > 0) ? string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(image.Content)) : "img/bg-showcase-2.jpg";


        }

        public List<OrderDetModel> GetOrderDetails(string[] Orders)//List<OrderHedModel> Orders,
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
                                var _result = JsonConvert.DeserializeObject<List<OrderDetModel>>(OrderDetails["value"].ToString());
                                if (_result != null) _result = _result.Where(x => Orders.Contains(x.OrderNum.ToString())).ToList();

                                ResponseModel _PObjResponse = null;
                                Dictionary<string, object> Objbinnum = null;
                                Dictionary<string, object> retobj = null;

                                string empty = string.Empty;

                                foreach (var _Order in _result)
                                {
                                    GetPartBinLocation(_PObjResponse, Objbinnum, retobj, _Order);
                                    _Order.ImageContent = GetItemImageByPartNumber(_Order.PartNum);
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

        private void GetPartBinLocation(ResponseModel _PObjResponse, Dictionary<string, object> Objbinnum, Dictionary<string, object> retobj, OrderDetModel _Order)
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
                            var partBinList = JsonConvert.DeserializeObject<List<OrderDetModel>>(retobj["PartBinSearch"].ToString()).Select(f => new { BinNum = f.BinNum, BinDesc = f.BinDesc, BinType = f.BinType }).FirstOrDefault();
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
            Order.OrderLine = orderline.ToString();
            Order.PickTime = DateTime.Now.ToString();           

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
                //var list = _DotitExtensionContext.Pickerorder.ToList();
                //var _list = list.FirstOrDefault(x => x.Ordernum == ordernum).Pickstatus = Status.Quarentine.ToString();
                //var Orderno1 = list.Find(x => x.Ordernum == ordernum);
                //#region code for remove from local list
                ////LineItemList.RemoveAt();
                ////LineItemList.Remove(Orderno1);
                //#endregion
            }
            #endregion

            if (status == Status.Replenish.ToString())
            {
                //hare we sent the email to stave for Replenish

            }
            if (status == Status.InventoryControl.ToString())
            {
                //hare we sent the email to stave for InventoryControl
                // or update order status Hold

            }
            //WriteToFile(Order, "pick");
            var orderstatus = OrderCompleteOrNot(ordernum);

            if (orderstatus != "Completed")
            { 
                return Json(msg);
            }
            else
            {
                #region status order Picked
                //var list = _DotitExtensionContext.Pickerorder.ToList();
                //var _list = list.FirstOrDefault(x => x.Ordernum == ordernum).Pickstatus = Status.Picked.ToString();

                //#region code for remove from local list
                ////LineItemList.RemoveAt();
                ////LineItemList.Remove(Orderno1);
                //#endregion
                #endregion
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
                WriteToFileOrderStatus(ordernum, "Completed");
                var completeorder = LineItemList.Find(o => o.OrderNum == ordernum);
                LineItemList.Remove(completeorder);

                orderstatus = "Completed";

            }
            return orderstatus;
        }
        public void WriteToFile(OrderHedModel ObjModel, string whattowrite)
        {
            var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.LogFilePath);
            if (whattowrite == "pick")
            {
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);
                PickWriter.WriteLine("Order Line " + ObjModel.OrderLine + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.UserId + " at time " + ObjModel.PickTime);
                PickWriter.Dispose();
                LogWriter.WriteLine("Order Line " + ObjModel.OrderLine + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.UserId + " at time " + ObjModel.PickTime);
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                QuarantineWriter.Dispose();
                LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                LogWriter.Dispose();
            }
        }
        public string[] ReadOrderProcessing()
        {

            string root = "wwwroot/OrderInProcessing.csv";
            List<string> csvlinesItems = System.IO.File.ReadLines(root).ToList();
            string[] authorsList = new string[csvlinesItems.Count];


            foreach (var _csvlinesItems in csvlinesItems)
            {
                authorsList = _csvlinesItems.Split(",");
            }

            return authorsList;
        }
        public void WriteToFileOrderProcessing(string[] Ordernum, string whattowrite)
        {

            if (whattowrite == "Processing")
            {
                var datetime = DateTime.Now;
                var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.OrderInProcessing);
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);
                foreach (var _Ordernum in Ordernum)
                {
                    PickWriter.WriteLine(_Ordernum + "," + 1 + "," + datetime);
                    LogWriter.WriteLine(_Ordernum + "," + 1 + "," + datetime);
                    //PickWriter.WriteLine ( "ordernumber " + _Ordernum + " userId " + 1 + " at time " + datetime);                    
                    //LogWriter.WriteLine(" ordernumber  " + _Ordernum + " userId " + 1 + " at time " + datetime);                   
                }
                PickWriter.Dispose();
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                //var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                //QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //QuarantineWriter.Dispose();
                //LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //LogWriter.Dispose();
            }
        }
        public void WriteToFileOrderStatus(int Ordernum, string whattowrite)
        {

            if (whattowrite == "Completed")
            {
                var datetime = DateTime.Now;
                var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.OrderStatus);
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);

                PickWriter.WriteLine(Ordernum + "," + +1 + "," + datetime + "," + "Completed");
                LogWriter.WriteLine(Ordernum + "," + 1 + "," + datetime + "," + "Completed");


                PickWriter.Dispose();
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                //var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                //QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //QuarantineWriter.Dispose();
                //LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //LogWriter.Dispose();
            }
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
            Order.PickTime = DateTime.Now.ToString();
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNumber).Single())).OrderPickStatus = "Quarantined";
            WriteToFile(Order, "quarantine");

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