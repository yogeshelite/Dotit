using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotIt.AutoPickerApi.Service

{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }
    }


    //public class DotItService : Controller, IHttpContextAccessor
    //{
    //    HttpContext IHttpContextAccessor.HttpContext { get; set; }
      

    //    public void SetCookie<T>(T datamodel,string key, int? expireTime, HttpResponse httpResponse)
    //    {

    //        CookieOptions option = new CookieOptions();
    //        if (expireTime.HasValue)
    //        {
    //            option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
    //        }
    //        else
    //            option.Expires = DateTime.Now.AddHours(10);


    //        var data = JsonConvert.SerializeObject(datamodel);
    //        httpResponse.Cookies.Append(key, data, option);
    //        option = null;
    //    }
    //    public T GetCookie<T>(string key,HttpRequest  httpRequest)
    //    {
    //        var get = httpRequest.Cookies[key];
    //        return JsonConvert.DeserializeObject<T>(httpRequest.Cookies[key]);
    //    }
    //    public void RemoveCookie(string key,HttpResponse httpResponse )
    //    {
    //        httpResponse.Cookies.Delete(key);
    //    }
    //}
}
