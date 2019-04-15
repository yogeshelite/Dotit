using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotit.OrderPicker.Models;
using Dotit.OrderPicker.Service;

namespace Dotit.OrderPicker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GetOrderList();



            return View();
        }

        private void GetOrderList()
        {
           // EpicorApiServices.GetOrderList();
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




    }
}
