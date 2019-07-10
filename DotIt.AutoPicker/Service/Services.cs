using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DotIt.AutoPicker.Models

{
    public class Services : Controller, IHttpContextAccessor
    {
        HttpContext IHttpContextAccessor.HttpContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        public void Set(string key, string value, int? expireTime)
        {
            
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
            {
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            }
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
    }
}
