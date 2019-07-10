using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using DotIt.AutoPicker.Models;
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

namespace DotIt.AutoPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHedModel> SaleOrderList;
        public static List<OrderHedModel> LineItemList;
        public static List<PickersModel> PickersList;
        public static List<FileStore> FileStoreList;
        Epicor10Context _dataContext = new Epicor10Context();

        public PickerController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index ()//this is our landing view string PickerDI
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
                DotItPickerContext dotItPickerContext = new DotItPickerContext();
                var picker = dotItPickerContext.Warehouseemployee.FromSql("GetEmployees").ToList();//hare we geting all pickers in local db
                ViewBag.Pickerddl = picker.ToList();
                #endregion

                return View();
            }
            catch
            {
                return RedirectToAction("Index", "Picker");
            }
            
        }

        public IActionResult Orders(string pickerId)
        {
            if (pickerId != null)
            {
                _dataContext = new Epicor10Context();
                #region /*Gobind*/ Sorting by picker by PickerId NCCO company or DIRF
                var dbpicker = _dataContext.UserFile.Where(x => x.DcdUserId == pickerId).Single();
                #endregion

                if (SaleOrderList == null)
                {
                    GetOrders();
                }
                #region hare we want to add images 
                // from erp.Part AS p
                //inner join erp.Image AS i on(p.Company = i.Company and p.ImageID = i.ImageID)
                //left join ice.filestore as fs on(fs.Company = i.Company and fs.SysRowID = i.ImageSysRowID)
                //where p.partnum = 'ppp
                #endregion
                #region @sandeep
                //IEnumerable<OrderHedModel> Orders = SaleOrderList.Take(1000);
                //SaleOrderList = Orders.ToList();
                //ViewBag.OrderList = SaleOrderList.Take(6);
                #endregion

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

                ApiResponse apiResponse = new ApiResponse();
                ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
                var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);

                if (OrderDetails.ContainsKey("value"))
                {

                    if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                    {
                        var GetLineOfItems = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderDetails["value"].ToString());
                        foreach (var lineitems in SaleOrderList.OrderBy(x => x.OrderNum))
                        {
                            var _GetLineOfItems = GetLineOfItems.Where(x => x.OrderNum == lineitems.OrderNum);

                            lineitems.OrderLine = _GetLineOfItems.Count().ToString();
                            _LocalSaleOrderList.Add(lineitems);
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
        public IActionResult Pick(string Ordernum3)
        {            
            string[] Ordernum = Ordernum3.Split(',');
            #region do shorting in saleorderlist for Priority wise but we don't have order status
            if (SaleOrderList != null)
            {
                ViewBag.OrderLineItems = GetOrderDetails(SaleOrderList, Ordernum);
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

        public void  GetOrders()//This is a method 
        {

            ApiResponse apiResponse = new ApiResponse();
            try
            {
                ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "GET");
                var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                if (OrderList.ContainsKey("value"))
                {
                    if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                    {
                        SaleOrderList = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderList["value"].ToString());
                        foreach (var OrderDate in SaleOrderList)
                        {
                            OrderDate.OrderDateTime = Convert.ToDateTime(OrderDate.OrderDate);
                        }
                        SaleOrderList = SaleOrderList.Where(o => o.OrderDateTime < (DateTime.Now)).OrderBy(o => o.OrderDateTime).ToList();
                    }
                }
            }
            catch
            {
                 RedirectToAction("Error", "Home");
            }
        }

        public string  GetimagesOfLineitems(string PartNumber)
        {


            var partimage = _dataContext.Part.Join(_dataContext.Image, p => new { p.Company, p.ImageId }, i => new { i.Company, i.ImageId }, (p, i) => new { PartNum= p.PartNum , Company = p.Company, ImageSysRowId= i.ImageSysRowId , ImageId = i.ImageId }).Join(_dataContext.FileStore, pi=>new { pi.Company, pi.ImageSysRowId },fl=>new{fl.Company ,fl.SysRowId } ,(pi,fl)=>new { image = fl.Content ,PartNumber= pi.PartNum} ) ;
            if(partimage!=null ) partimage.
            //dataContext.Parts part = (from p in dataContext.Part where p.PartNum == PartNumber select p).Single();

                //from erp.Part AS p
                //            inner join erp.Image AS i on(p.Company = i.Company and p.ImageID = i.ImageID)
                //            left join ice.filestore as fs on(fs.Company = i.Company and fs.SysRowID = i.ImageSysRowID)
                //            where p.partnum = PartNumber
        }
        public List<OrderHedModel> GetOrderDetails(List<OrderHedModel> Orders, string[] Ordernum)
        {
            List<OrderHedModel> _LocalSaleOrderList = new List<OrderHedModel>();
            List<OrderHedModel> OrderLineItems = new List<OrderHedModel>();
            ApiResponse apiResponse = new ApiResponse();
            //ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
            ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
            if (ObjResponse.success == true)
            {
                var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                if (OrderDetails.ContainsKey("value"))
                {

                    if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                    {
                        var _result = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderDetails["value"].ToString());
                        foreach (var OrderDate in _result)
                        {
                            
                                  OrderDate.OrderDateTime = Convert.ToDateTime(OrderDate.OrderDate);
                        }
                        #region sandeep code
                        //if (Orders != null)
                        //{
                        //    foreach (var order in Orders)
                        //    {
                        //        foreach (var Od in _result)
                        //        {
                        //            if (Od.OrderNum == order.OrderNum)
                        //            {
                        //                OrderLineItems.Add(Od);
                        //                #region
                        //                //var result = dbcs.Part.Join(
                        //                //dbcs.Image,
                        //                //    p => p.ImageId,
                        //                //    img => img.ImageId,
                        //                //    (p, img) => new { p, img }
                        //                //).ToList();
                        //                //var d = result.Join(dbcs.FileStore, pimg => new { pimg.img.Company, pimg.img.ImageSysRowId }, fl => new { fl.Company, fl.SysRowId }, (fl) => new { fs = fl });

                        //                //var d = from p in dbcs.Part
                        //                //        from i in dbcs.Image on p.ImageId equals i.ImageId
                        //                //        from fl in dbcs.FileStore on new { p.Company, i.ImageSysRowId } equals new { fl.Company, fl.SysRowId }
                        //                //        into fs
                        //                //        select new { fs} ;



                        //                //from erp.Part AS p
                        //                //    inner join erp.Image AS i on(p.Company = i.Company and p.ImageID = i.ImageID)
                        //                //   left join ice.filestore as fs on(fs.Company = i.Company and fs.SysRowID = i.ImageSysRowID)
                        //                //   where p.partnum = PartNumber.


                        //                //var imageblob = dbcs.Part.
                        //                //Join(dbcs.Image, im => im.Company, imid => imid.ImageId,
                        //                //(im, imid) => new { im, imid }).
                        //                //Join(dbcs.FileStore, fc => fc.im.Company, fs => fs.SysRowId, (fc, fs) => new { fc, fs })).Where(p => Od.PartNum);

                        //                #endregion
                        //            }
                        //        }

                        //    }
                        //}
                        #endregion


                        #region for image show but not find imagesysrowid
                        //var _FileStoreList = dbcs.UserFile.ToList();
                        //var _partList = dbcs.Part.ToList();
                        //var imageblob = from fs in dbcs.FileStore
                        //                where fs.SysRowId =(Guid) OrderDate.PartNum;
                        #endregion


                        List< OrderHedModel > Localobj = new List<OrderHedModel>();
                        foreach (var _ordernum in Ordernum)
                        {
                            if (_ordernum != null)
                            {

                                var TotallineItems = _result.Where(x => x.OrderNum == Convert.ToInt32(_ordernum));
                                if (TotallineItems != null)
                                {
                                    foreach (var _TotallineItems in TotallineItems)
                                    {
                                       
                                        _LocalSaleOrderList.Add(_TotallineItems);
                                    }
                                }

                            }
                            else
                            {

                            }
                        }

                        #region
                        //OrderLineItems.First().TotalLines = OrderLineItems.Count();
                        //return OrderLineItems;
                        #endregion
                        LineItemList = _LocalSaleOrderList;
                        return _LocalSaleOrderList;
                    }
                }
            }
            else {
                RedirectToAction("Error", "Home");
            }
            return null;
        }

        public JsonResult PickLineItems(int ordernum, int orderline)
        {
            var Order = SaleOrderList.Where(o => o.OrderNum == ordernum).Single();
            Order.OrderLine = orderline.ToString();
            Order.PickTime = DateTime.Now.ToString();
            #region
            //SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == ordernum).Single())).OrderPickStatus = "Processing";
            //SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id && o.OrderLine== orderline.ToString()).Single())).OrderPickStatus = "Processing";
            #endregion

            var updatelist =LineItemList.Where(o => o.OrderNum == ordernum && o.OrderLine == orderline.ToString()).Single().OrderPickStatus = "Processing";

            
            WriteToFile(Order, "pick");

            var orderstatus= OrderCompleteOrNot(ordernum);
            if (orderstatus != "Completed")
            {
                return Json("Order in  Pick Process");
            }
            else
            {

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
                WriteToFileOrderStatus(ordernum , "Completed");
                var completeorder=LineItemList.Find(o => o.OrderNum == ordernum);
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
            string[] authorsList=new string[csvlinesItems.Count];
            
            
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
                    PickWriter.WriteLine( _Ordernum + "," + 1 + "," + datetime);
                    LogWriter.WriteLine( _Ordernum + "," + 1 + "," + datetime);
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
               
                    PickWriter.WriteLine(Ordernum + ","+ + 1 + "," + datetime + "," + "Completed");
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
            string [] Ordernum = null;
            ViewBag.OrderLineItems = GetOrderDetails(SaleOrderList,Ordernum).Where(x => x.OrderNum != OrderNumber);
            return View("Pick");
        }

        public IActionResult Profile(int id)
        {
            DotItPickerContext dotItPickerContext = new DotItPickerContext();

            var AllPickers = dotItPickerContext.Warehouseemployee.FromSql("GetEmployees").ToList();
            var GetWarehouseemployeeBYId = AllPickers.Where(x => x.Empid == id).ToList();
            Warehouseemployee model = AllPickers.Where(x => x.Empid == id).FirstOrDefault();

            return View(model);
        }
        [HttpPost]
        public ActionResult ProfileChanges(Warehouseemployee model)
        {
            DotItPickerContext dotItPickerContext = new DotItPickerContext();
            if (ModelState.IsValid)
            {
                dotItPickerContext.Entry(model).State = EntityState.Modified;
                dotItPickerContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}