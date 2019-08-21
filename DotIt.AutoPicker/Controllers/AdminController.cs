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
using DotIt.AutoPicker.Persistance.Repository;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace DotIt.AutoPicker.Controllers
{
    public class AdminController : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly DotitExtensionContext _DotitExtensionContext;
        private readonly IPickerRepository _pickerRepository;
        private StackTrace _stackTrace ;

        public static bool allowaccess = false;
        ApiResponse _apiResponse;

        public AdminController(IHostingEnvironment hostingEnvironment, DotitExtensionContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _DotitExtensionContext = context;
            _stackTrace = new StackTrace();
            _pickerRepository = new PickerRepository(_stackTrace);
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
        public IActionResult AddProfile()
        {

            var UserLogInName = HttpContext.Session.Get<UserFile>(Constant.UserCookie.ToString());
            if (UserLogInName == null)
            {
                return RedirectToAction("Default");
            }
            return View();
        }
        public IActionResult Default()
        {
            return View();
        }


        public JsonResult Login(string UserName)
        {
            var ReturnResponse = "";
            using (_apiResponse = new ApiResponse())
            {
                //ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, UserName), "GET");
                //if(!ObjResponse.success) return Json(ObjResponse.Response);



                var user = _pickerRepository.GetPickers(docuserid: UserName).FirstOrDefault();
                //JsonConvert.DeserializeObject<PickerModel>(ObjResponse.Response);


                if (user != null)
                {

                    if (user.Grouplist.Split("~").Where(f => new string[] { UserGroup.WHSE.ToString(), UserGroup.WHSEMGR.ToString(), UserGroup.WHSELEAD.ToString() }.Contains(f)).Count() > 0)
                    {
                        HttpContext.Session.Set(Constant.UserCookie.ToString(), user);
                        ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, UserName), "GET");
                        if (!ObjResponse.success)
                        {
                            ReturnResponse = "{\"Response\":\"User Not Exist In Epicore \"}";
                        }
                        else
                        {
                            
                            ReturnResponse = ObjResponse.Response;
                            // List<Directory<string,string>>listUserData=JsonConverter.(ObjResponse.success)
                        }
                        // var redirectaction = user.Grouplist.Contains(UserGroup.WHSEMGR.ToString()) ? "../../Admin/Home/" : "../../Picker/Index/";
                        
                    }

                    //return Json("Not a picker user");
                }
                else {
                    ReturnResponse = "{\"Response\":\"User Not Exist \"}";
                }

                return Json(ReturnResponse);
            }
        }

        public IActionResult Home()
        {
            var UserLogInName = HttpContext.Session.Get<PickerModel>(Constant.UserCookie.ToString());

            if (UserLogInName != null)
            {
                //ViewBag.LogInName = UserLogInName.DcdUserID;
                ViewBag.Pickers = GetPickers(dcduserid: UserLogInName.DcdUserID);
                GetEpicoreOrder();
                return View();
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
                string[] PickComp = new string[2];
                if (!string.IsNullOrWhiteSpace(warehouseemployee.PickForCompany))
                {
                    PickComp = warehouseemployee.PickForCompany.Split(',');
                }
                
                PickerModel pickerModel = new PickerModel()
                {
                    EMailAddress = warehouseemployee.Emailaddress,
                    Grouplist = warehouseemployee.Grouplist.Replace("~", ","),
                    Name = warehouseemployee.Pickername,
                    RecordDate = warehouseemployee.Recorddate,
                    DcdUserID = warehouseemployee.Dcduserid,
                    // EmpID = pickerModel.Empid;
                    Active = warehouseemployee.active,
                    AdminlineperHour = warehouseemployee.Adminlineperhour,
                    LastLogin = warehouseemployee.Lastlogin,
                    MaxLines = warehouseemployee.Maxlines,
                    MaxWeight = warehouseemployee.Maxweight,
                    UserHeight=warehouseemployee.UserHeight,
                    WeightCapacity=warehouseemployee.WeightCapacity,
                   
                };
                if (PickComp[0] == "NCCO")
                    pickerModel.Ncco = true;
                else
                    pickerModel.Ncco = false;
                if (PickComp[0] == "DIRF")
                    pickerModel.Dirf = true;
                else
                    pickerModel.Dirf = true;

                if (PickComp[1] == "NCCO")
                    pickerModel.Ncco = true;
                else
                    pickerModel.Ncco = false;
                if (PickComp[1] == "DIRF")
                    pickerModel.Dirf = true;
                else
                    pickerModel.Dirf = false;
                if (PickComp[0] == "NCCO" && PickComp[1] == "DIRF")
                {
                    pickerModel.Dirf = true;
                    pickerModel.Ncco = true;
                }
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
                result2 = result2.Where(f => (string.IsNullOrEmpty(dcduserid) | ! f.Dcduserid.Equals(dcduserid))).ToList();
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
               // user.Grouplist = warehouseemployee.Grouplist.Replace(",", "~");
                user.Pickername = warehouseemployee.Name;
                user.Recordupdatedate =DateTime.Now;
                user.Dcduserid = warehouseemployee.DcdUserID;              
                user.active = warehouseemployee.Active;
                user.Adminlineperhour = warehouseemployee.AdminlineperHour;
                user.Lastlogin = warehouseemployee.LastLogin;
                user.Maxlines = warehouseemployee.MaxLines;
                user.Maxweight = warehouseemployee.MaxWeight;
                user.UserHeight = warehouseemployee.UserHeight;
                user.WeightCapacity = warehouseemployee.WeightCapacity;
                user.PickForCompany = warehouseemployee.PickForCompany;
            }
            _DotitExtensionContext.SaveChanges();           
            return Json("Profile updated");
        }
      
        public JsonResult AddProfileData(PickerModel warehouseemployee)
        {
            // var user = _DotitExtensionContext.Warehouseemployee.FirstOrDefault(x => x.Emailaddress == warehouseemployee.EMailAddress);
            Warehouseemployee obj = new Warehouseemployee();
           
            if (obj != null)
            {
                obj.Emailaddress = warehouseemployee.EMailAddress;
                obj.Grouplist = "WHSE";
                obj.Pickername = warehouseemployee.Name;
                obj.Recordupdatedate = DateTime.Now;
                obj.Dcduserid = warehouseemployee.Name.ToUpper();
                obj.active = warehouseemployee.Active;
                obj.Adminlineperhour = warehouseemployee.AdminlineperHour;
                obj.Lastlogin = warehouseemployee.LastLogin;
                obj.Maxlines = warehouseemployee.MaxLines;
                obj.Maxweight = warehouseemployee.MaxWeight;
                obj.UserHeight = warehouseemployee.UserHeight;
                obj.WeightCapacity = warehouseemployee.WeightCapacity;
                //obj.PickForCompany = warehouseemployee.PickForCompany;
            }
            _DotitExtensionContext.Warehouseemployee.Add(obj);
            _DotitExtensionContext.SaveChanges(); 
            return Json("Profile Add");
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

        public JsonResult GetEpicoreOrder()
        {
            string ReturnResponse = "";
            using (_apiResponse = new ApiResponse())
            {
                ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrderList, "GET");
                if (!ObjResponse.success)
                {
                    ReturnResponse = "{\"Response\":\"No Sale Order Found \"}";
                }
                else
                {

                    ReturnResponse = ObjResponse.Response;
                    // List<Directory<string,string>>listUserData=JsonConverter.(ObjResponse.success)
                }
                return Json(Response);
            }
        }
    }
}
