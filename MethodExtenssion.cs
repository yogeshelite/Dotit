using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Erp.BO.SalesOrderDataSet;


namespace EpicorDaily
{
    public  class MethodExtenssion
    {
        public static  T ConvertDictionaryTo<T>(IDictionary<string, object> dictionary) where T : new()
        {
            Type type = typeof(T);
            T ret = new T();
           var  _dictionary = dictionary.Where(f => !f.Key.Equals("odata.metadata")) ;
            foreach (var keyValue in _dictionary)
            {
                type.GetProperty(keyValue.Key).SetValue(ret, keyValue.Value, null);
            }

            return ret;
        }
        //public static String ConvertToJsonString<String>(IDictionary<string, object> dictionary) where String : new()
        //{

        //    //OrderHedRow ohr = new OrderHedRow();

        //    // foreach (var property in ohr)
        //    // {
        //    //     type.GetProperty(keyValue.Key).SetValue(ret, keyValue.Value, null);
        //    // }
        //    string data = "";
        //    return data;
        //}
        public void stringBuild()
        {
            string data = "{"+"orderType_c" +","+":"+","+ "Online" +","+ "InvoiceComment"+","+ ":"+","+ ""+","+ "RequestDate"+","+ ":"+","+ ""+","+  "PayFlag"+","+ ":"+","+ "SHIP"+","+  "FOB" +","+ "Delivered"+","+ "ApplyChrg" +","+ "false"+","+ "ChrgAmount" +","+":"+","+ 0.0+","+ "OrderComment" +","+":" +","+ "Email" +","+ ":" +","+ "tsauvageau @coolgreens.com < EmailEnd >" +","+ "ShipViaCode" +","+ ":" +","+   "UPC" +","+"}";
        }
    }
}
