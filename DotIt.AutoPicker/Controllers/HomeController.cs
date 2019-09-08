using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotIt.AutoPicker.Models;

using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHeadModel> SaleOrderList;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            if (SaleOrderList == null)
            {
                View("Index");
                //GetOrders();
            }
            ViewBag.OrderList = SaleOrderList.Where(o => o.TotalLines < 50).Take(Constant.NumberOfOrdersToShow);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PickOrder(string id)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));

            ViewBag.OrderDetails = GetOrderDetailsAsync(OrderNum);
            OrderHeadModel ObjModel = new OrderHeadModel();
           // ObjModel.TotalLines = (int)ViewBag.OrderDetails.Count;
            ObjModel.OrderNum = OrderNum;
            return View(ObjModel);
        }

        public JsonResult PickLineItem(int id, int orderline)
        {
            var Order = SaleOrderList.Where(o => o.OrderNum == id).Single();
           // Order.TotalLines  = orderline;
            Order.PickDate = DateTime.Now;
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id).Single())).OrderPickStatus = "Processing";

            //WriteToFile(Order);
            return Json("Order in  Pick Process");
        }

        public JsonResult UnPickLineItem(int id)
        {
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id).Single())).OrderPickStatus = "";
            return Json("Order unpicked");
        }
        public IActionResult MoveToQuarantine(string id)
        {

            int Id = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == Id).Single())).OrderPickStatus = "Quarantined";
            ViewBag.OrderList = SaleOrderList.Take(Constant.NumberOfOrdersToShow);
            return View("Index");
        }

        public IActionResult CancelOrderPick(string id)
        {
            int Id = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == Id).Single())).OrderPickStatus = "";
            ViewBag.OrderList = SaleOrderList.Take(Constant.NumberOfOrdersToShow);
            return View("Index");
        }

        public IActionResult CompleteOrder(string id)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNum).Single())).OrderPickStatus = "Completed";
            ViewBag.OrderList = SaleOrderList;
            return View("Index");
        }

        public async Task<List<OrderHeadModel>> GetOrdersAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = await apiResponse.GetApiResponseAsync(Constant.EpicorApi_SalesOrder, "GET");
            var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderList.ContainsKey("value"))
            {
                if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                {
                    SaleOrderList = JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderList["value"].ToString());
                    foreach (var OrderDate in SaleOrderList)
                    {
                        OrderDate.OrderDateTime = Convert.ToDateTime(OrderDate.OrderDate);
                    }
                    return SaleOrderList.Where(o => o.OrderDateTime < (DateTime.Now)).OrderBy(o => o.OrderDateTime).ToList();
                }
            }
            return null;
        }
        public async Task<OrderHeadModel> GetOrderbyordernumAsync()
        {
            string url = string.Format(Constant.EpicorApi_SalesOrderByOrdernum, "DIRF", "210847");
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = await apiResponse.GetApiResponseAsync(url, "GET");
            var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderList.ContainsKey("value"))
            {
                if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                {
                    var list = JsonConvert.DeserializeObject<OrderHeadModel>(OrderList["value"].ToString());
                    return list;
                }
            }
            return null;
        }

        public async Task<List<OrderDetailModel>> GetOrderDetailsAsync(int ordernum)
        {
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = await apiResponse.GetApiResponseAsync(Constant.EpicorApi_OrderDetails, "GET");
            var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderDetails.ContainsKey("value"))
            {

                if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                {
                    var _result = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
                    //foreach (var OrderDate in _result)
                    //{
                    //    OrderDate.OrderDate = Convert.ToDateTime(OrderDate.OrderDate);
                    //}
                    return _result.Where(o => o.OrderNum == ordernum).ToList();
                }
            }
            return null;
        }

        public void WriteToFile(OrderHeadModel ObjModel)
        {
            //string WebRootPath = _hostingEnvironment.WebRootPath;
            //var logPath =  WebRootPath+Constant.LogFilePath;
            //var LogWriter = System.IO.File.AppendText(logPath);
            //LogWriter.WriteLine(ObjModel.OrderNum + "," + ObjModel.TotalLines + "," + ObjModel.Company + "," + ObjModel.CustNum + "," + ObjModel.OrderDateTime + "," + ObjModel.AllocPriorityCode + "," + ObjModel.ReservePriorityCode + "," + ObjModel.TotalLines + "," + ObjModel.PONum + "," + ObjModel.PickDate + "," + ObjModel.PickerUserId);
            //LogWriter.Dispose();
        }
    }
}
