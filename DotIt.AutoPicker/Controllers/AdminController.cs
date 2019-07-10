using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using CsvHelper;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using DotIt.AutoPicker.Models;
namespace DotIt.AutoPicker.Controllers
{
    public class AdminController : Controller
    {
        Services servicesCookies= new Services();
        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly DotItPickerContext _context;

        public static bool allowaccess = false;

        public AdminController(IHostingEnvironment hostingEnvironment, DotItPickerContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            var UserLogInName = Get("UserName");
            if (UserLogInName != string.Empty)
            {
                return RedirectToAction("Home");
            }
            return View();
        }

        public JsonResult Login(AdminModel objModel)
        {
            TextReader reader = new StreamReader(_hostingEnvironment.WebRootPath + Constant.AdminCredentialsPath);
            var CSVReader = new CsvReader(reader);
            var records = CSVReader.GetRecords<AdminModel>();
            foreach (var credential in records)
            {
                if (objModel.Username == credential.Username)
                {
                    if (objModel.Password == credential.Password)
                    {
                        Set("UserName", credential.Username, 100);
                          //servicesCookies.Set("UserName", credential.Username,100);
                            return Json("success");
                    }
                    else
                    {
                        ViewBag.LoginResponse = "Invalid Password";
                        return Json("password wrong");
                    }
                }
            }
            ViewBag.LoginResponse = "Invalid UserName";
            return Json("username wrong");
        }

        public IActionResult Home()
        {
            var UserLogInName = Get("UserName");
            
            if (UserLogInName != string.Empty)
            {
                ViewBag.LogInName = UserLogInName;
                ViewBag.Pickers = GetEmployees();
                return View();
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult EditProfile(string id)
        {
            
            int Empid = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            ViewBag.EmployeeDetails = GetEmployees().Where(x => x.Empid == Empid).Single();
            ViewBag.LogInName = Get("UserName");
            return View("Profile");
        }

        public List<Warehouseemployee> GetEmployees()
        {
            Warehouseemployee objModel = new Warehouseemployee();
            var context = new DotItPickerContext();
            return context.Warehouseemployee.FromSql("GetEmployees").ToList();
        }

        public JsonResult SaveProfile(Warehouseemployee warehouseemployee)
        {
            var context = new DotItPickerContext();
            var result = context.Database.ExecuteSqlCommand($"UpdateProfile {warehouseemployee.Empid},{warehouseemployee.Name},{warehouseemployee.Email},{warehouseemployee.Role},{warehouseemployee.Pickncco},{warehouseemployee.Pickdotit},{warehouseemployee.Maxlines},{warehouseemployee.Maxweight},{warehouseemployee.Adminlineperhour}");
            //FromSql($"UpdateProfile {warehouseemployee.Empid},{warehouseemployee.Name},{warehouseemployee.Email},{warehouseemployee.Role},{warehouseemployee.Pickncco},{warehouseemployee.Pickdotit},{warehouseemployee.Maxlines},{warehouseemployee.Maxweight},{warehouseemployee.Adminlineperhour}");
            return Json("Profile updated");
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(10);
            Response.Cookies.Append(key, value,option);
        }
        public string Get(string key)
        {
            var get = Request.Cookies[key];
            //var remove = Remove("UserName");
            return Request.Cookies[key];
        }
        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
        public IActionResult LogOut(string id)
        {
            Remove("UserName");
            return View("Index");
        }

    }
}
