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
using DotIt.AutoPicker.Data.Epicor;
using DotIt.AutoPicker.Data;
using DotIt.AutoPicker.Data.DotIt;

namespace DotIt.AutoPicker.Controllers
{
    public class AdminController : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly DotitExtensionContext _DotitExtensionContext;



        public static bool allowaccess = false;
        ApiResponse _apiResponse;

        public AdminController(IHostingEnvironment hostingEnvironment, DotitExtensionContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _DotitExtensionContext = context;

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


        public JsonResult Login(string UserName)
        {
            using (_apiResponse = new ApiResponse())
            {
                ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, UserName), "GET");
                var user = JsonConvert.DeserializeObject<PickerModel>(ObjResponse.Response);


                if (user != null)
                {

                    if (user.Grouplist.Split("~").Where(f => new string[] { UserGroup.WHSE.ToString(), UserGroup.WHSEMGR.ToString(), UserGroup.WHSELEAD.ToString() }.Contains(f)).Count() > 0)
                    {
                        HttpContext.Session.Set<PickerModel>(Constant.UserCookie.ToString(), user);

                        return Json("success");
                    }

                    //return Json("Not a picker user");
                }

                return Json("User not exist");
            }
        }

        public IActionResult Home()
        {
            var UserLogInName = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());

            if (UserLogInName != null)
            {
                //ViewBag.LogInName = UserLogInName.DcdUserID;
                //ViewBag.Pickers = GetPickers(dcduserid: UserLogInName.DcdUserID);
                return View(GetPickers(dcduserid: UserLogInName.DcdUserID));
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult EditProfile(string id)
        {
            string DcdUserID = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id));

            Warehouseemployee warehouseemployee = _DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Dcduserid == DcdUserID);

            if (warehouseemployee != null)
            {
                PickerModel pickerModel = new PickerModel()
                {
                    EMailAddress = warehouseemployee.Emailaddress,
                    Grouplist = warehouseemployee.Grouplist.Replace(",", "~"),
                    Name = warehouseemployee.Pickername,
                    RecordDate = warehouseemployee.Recorddate,
                    DcdUserID = warehouseemployee.Dcduserid,
                    // EmpID = pickerModel.Empid;
                    Active = warehouseemployee.active,
                    AdminlineperHour = warehouseemployee.Adminlineperhour,
                    LastLogin = warehouseemployee.Lastlogin,
                    MaxLines = warehouseemployee.Maxlines,
                    MaxWeight = warehouseemployee.Maxweight,
                };
                return View(pickerModel);

            }
            //ViewBag.EmployeeDetails = GetPickers(dcduserid: DcdUserID).Single();
            //ViewBag.LogInName = HttpContext.Session.Get<UserFile>(Constant.UserCookie.ToString());
            return View("Home");
        }

        public List<PickerModel> GetPickers(string dcduserid, string company = "")
        {
            List<PickerModel> result = null;
            try
            {
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();



                var result2 = _DotitExtensionContext.Warehouseemployee.ToList();

                // (string.IsNullOrEmpty(company) | f.Company.Equals(company))
                result2 = result2.Where(f => (string.IsNullOrEmpty(dcduserid) | f.Dcduserid.Equals(dcduserid))).ToList();
                if (result2 == null)
                { return result; }


                result = result2.Select(f => new PickerModel()
                {
                    EMailAddress = f.Emailaddress,
                    Grouplist = f.Grouplist.Replace("~", ","),
                    Name = f.Pickername,
                    RecordDate = f.Recorddate,
                    DcdUserID = f.Dcduserid,
                    // EmpID = f.Empid,
                    Active = f.active,
                    AdminlineperHour = f.Adminlineperhour,
                    LastLogin = f.Lastlogin,
                    MaxLines = f.Maxlines,
                    MaxWeight = f.Maxweight
                }).ToList();


                //DLog.Log("Epicor Picker user sync successfully");

                //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();


            }
            catch (Exception ex)
            {
                // DLog.Log("Error No picker  can not desealize ");
            }
            return result;
        }


        public JsonResult SaveProfile(PickerModel warehouseemployee)
        {
           var user= _DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Dcduserid == warehouseemployee.DcdUserID);
            if (user != null)
            {
                user.Emailaddress = warehouseemployee.EMailAddress;
                user.Grouplist = warehouseemployee.Grouplist.Replace(",", "~");
                user.Pickername = warehouseemployee.Name;
                user.Recorddate = warehouseemployee.RecordDate;
                user.Dcduserid = warehouseemployee.DcdUserID;              
                user.active = warehouseemployee.Active;
                user.Adminlineperhour = warehouseemployee.AdminlineperHour;
                user.Lastlogin = warehouseemployee.LastLogin;
                user.Maxlines = warehouseemployee.MaxLines;
                user.Maxweight = warehouseemployee.MaxWeight; 
            }
            _DotitExtensionContext.SaveChanges();           
            return Json("Profile updated");
        }
        public IActionResult DeleteProfile(string id ,bool active)
        {
            string DcdUserID = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id));

            var user = _DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Dcduserid == DcdUserID);
            if (user != null)
            {
                PickerModel pickerModel = new PickerModel()
                {
                    Active = active
                };

                    //user.Active = warehouseemployee.Active;
                
            }
            _DotitExtensionContext.SaveChanges();
            return View("Home");
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
