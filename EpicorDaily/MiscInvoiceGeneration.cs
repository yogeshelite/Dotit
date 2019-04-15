using EpicorDaily.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily
{
    public class MiscInvoiceGeneration
    {



        //internal static void GenerateMiscInvoice()
        //{
        //    ApiResponse apiResponse = new ApiResponse();

        //    var _response = apiResponse.GetApiResponse("Erp.BO.SalesOrderSvc/OrderDtls", "Get");
        //    if (_response.success)
        //    {
        //        var _data = JsonConvert.DeserializeObject <Dictionary<string, object>>(_response.Response);
        //        if (_data.ContainsKey("value"))
        //        {
                   
        //            if (!String.IsNullOrEmpty(_data["value"].ToString()))
        //            {
        //              var  _Orderlines = JsonConvert.DeserializeObject<List<OrderDetailModel>>(_data["value"].ToString()).Where(f=>!f.OpenLine & !f.IsBankInvoiced).OrderBy(f=>f.BankId);

        //                var _BankList = _Orderlines.Select(f => f.BankId).Distinct(); 

        //                foreach (var _bankId in _BankList)
        //                {
        //                        CreateBankMiscInvoice(_Orderlines, _bankId);
        //                }


        //            }




        //        }

        //    }
           

        //}

        //private static void CreateBankMiscInvoice(IOrderedEnumerable<OrderDetailModel> orderlines, int bankId)
        //{
        //    var Lines = orderlines.Where(f => f.BankId.Equals(bankId));
            
        //}
    }
}
