using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using CsvHelper;
using DotIt.AutoPicker.Models;
///using DotIt.AutoPicker.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using DotIt.AutoPicker.Services;

namespace DotIt.AutoPicker.Controllers
{
    public class AdminController : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;

       // private readonly DotItPickerContext _context;

        public static bool allowaccess = false;
        ApiResponse _apiResponse;

        public AdminController(IHostingEnvironment hostingEnvironment)//, DotItPickerContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            //_context = context;

        }

        public IActionResult Index()
        {

            var UserLogInName = HttpContext.Session.Get<UserFile>(Constant.UserCookie.ToString());
            if (UserLogInName != null)
            {
                return RedirectToAction("Home");
            }
            return View();
        }

        public IActionResult Default()
        {
            return View();
        }


        public JsonResult Login(AdminModel objModel)
        {
            using (_apiResponse = new ApiResponse())
            {
                ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, objModel.Username), "GET");
                var user = JsonConvert.DeserializeObject<UserFile>(ObjResponse.Response);


                if (user != null)
                {

                    if   (user.GroupList.Split("~").Where(f=> new string[] { UserGroup.WHSE.ToString(), UserGroup.WHSEMGR.ToString(), UserGroup.WHSELEAD.ToString() }.Contains(f )).Count() >0 ) 
                    {
                        HttpContext.Session.Set<UserFile>(Constant.UserCookie.ToString(), user);

                        return Json("success");
                    }

                    //return Json("Not a picker user");
                }

                return Json("User not exist");
            }
        }

        public IActionResult Home()
        {
            var UserLogInName = HttpContext.Session.Get<UserFile>(Constant.UserCookie.ToString());

            if (UserLogInName != null)
            {
                ViewBag.LogInName = UserLogInName.DcdUserID;
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
            ViewBag.LogInName = HttpContext.Session.Get<UserFile>(Constant.UserCookie.ToString());
            return View("Profile");
        }

        public List<Warehouseemployee> GetEmployees()
        {
            Warehouseemployee objModel = new Warehouseemployee();

            return new List<Warehouseemployee> ();//  _context.Warehouseemployee.FromSql("GetEmployees").ToList();
        }

        public JsonResult SaveProfile(Warehouseemployee warehouseemployee)
        {

          //  var result = _context.Database.ExecuteSqlCommand($"UpdateProfile {warehouseemployee.Empid},{warehouseemployee.Name},{warehouseemployee.Email},{warehouseemployee.Role},{warehouseemployee.Pickncco},{warehouseemployee.Pickdotit},{warehouseemployee.Maxlines},{warehouseemployee.Maxweight},{warehouseemployee.Adminlineperhour}");
            //FromSql($"UpdateProfile {warehouseemployee.Empid},{warehouseemployee.Name},{warehouseemployee.Email},{warehouseemployee.Role},{warehouseemployee.Pickncco},{warehouseemployee.Pickdotit},{warehouseemployee.Maxlines},{warehouseemployee.Maxweight},{warehouseemployee.Adminlineperhour}");
            return Json("Profile updated");
        }

        //public void Set(string key, string value, int? expireTime)
        //{
        //    CookieOptions option = new CookieOptions();
        //    if (expireTime.HasValue)
        //        option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
        //    else
        //        option.Expires = DateTime.Now.AddHours(10);
        //    Response.Cookies.Append(key, value, option);
        //}
        //public string Get(string key)
        //{
        //    var get = Request.Cookies[key];
        //    //var remove = Remove("UserName");
        //    return Request.Cookies[key];
        //}
        //public void Remove(string key)
        //{
        //    Response.Cookies.Delete(key);
        //}
        public IActionResult LogOut(string id)
        {
            HttpContext.Session.Remove(Constant.UserCookie.ToString());
            return View("Index");
        }

    }
}
