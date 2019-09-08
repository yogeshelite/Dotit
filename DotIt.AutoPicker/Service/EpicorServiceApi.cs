using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public class EpicorServiceApi
    {

        public ApiResponse _apiResponse { get; set; }
        public async Task<List<OrderHeadModel>> GetEpicoreOrderAsync()
        {
            List<OrderHeadModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    string dt = string.Format("{0:s}", DateTime.Now.AddDays(-90));
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(string.Format(Constant.EpicorApi_SalesOrderFilter, "true", dt), "GET");
                    //ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrderFilter, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                List<OrderHeadModel> _result = JsonConvert.DeserializeObject<List<OrderHeadModel>>(OrderDetails["value"].ToString());
                                if (_result != null)
                                {
                                    _result = _result.ToList();
                                    resultOrderList = _result.Where(x => x.OrderDtls.Count() > 0).OrderByDescending(f => f.RequestDate).ToList();
                                }
                            }
                        }
                    }
                    else
                    {
                        //RedirectToAction("Error", "Home");
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.Message.ToString();
                }
            }
            return resultOrderList;


        }
      
        public async Task<List<PartBinModel>> GetPartBinAsync(string partnum)
        {
            List<PartBinModel> resultOrderList = null;
            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    var databody = "{ \"PageSize\": \"0\",\"AbsolutePage\": \"0\",\"whereClause\": \"PartNum\"='" + partnum + "'\"}";
                    var input = new
                    {
                        PageSize = 10,
                        AbsolutePage = 0,
                        whereClause = "PartNum='" + partnum + "'"
                    };
                    string inputJson = JsonConvert.SerializeObject(input);
                    ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(Constant.EpicorApi_PartBinSearch, "post", inputJson);
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("returnObj"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["returnObj"].ToString()))
                            {
                                var _resultReturnObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(OrderDetails["returnObj"].ToString());
                                if (_resultReturnObj != null)
                                {
                                    resultOrderList = JsonConvert.DeserializeObject<List<PartBinModel>>(_resultReturnObj["PartBinSearch"].ToString());

                                    //_result = _result.ToList();

                                    //resultOrderList = _result.Where(x => x.OpenOrder == true && x.TotalWgt_c > 0)
                                    //                               .ToList();
                                }
                            }
                        }
                    }
                    else
                    {
                        //RedirectToAction("Error", "Home");
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.Message.ToString();
                }
            }
            return resultOrderList;


        }
        public async Task<List<PartsModel>> GetPartsAsync()
        {
            List<PartsModel> resultOrderList = null;


            using (_apiResponse = new ApiResponse())
            {
                try
                {
                    ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(Constant.EpicorApi_Parts, "GET");
                    if (ObjResponse.success == true)
                    {
                        var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (OrderDetails.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                            {
                                List<PartsModel> _result = JsonConvert.DeserializeObject<List<PartsModel>>(OrderDetails["value"].ToString());
                                if (_result != null)
                                {


                                    _result = _result.ToList();

                                    resultOrderList = _result.ToList();
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message.ToString();
                }
            }
            return resultOrderList;


        }
        //public int TotalEpicorLineitems()
        //{
        //    List<OrderHeadModel> _LocalSaleOrderList = new List<OrderHeadModel>();
        //    if (SaleOrderList != null && SaleOrderList.Count() > 0)
        //    {

        //        using (_apiResponse = new ApiResponse())
        //        {
        //            ResponseModel ObjResponse = _apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
        //            var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);

        //            if (OrderDetails.ContainsKey("value"))
        //            {

        //                if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
        //                {
        //                    var GetLineOfItems = JsonConvert.DeserializeObject<List<OrderDetailModel>>(OrderDetails["value"].ToString());
        //                    foreach (var lineitems in SaleOrderList.OrderBy(x => x.OrderNum))
        //                    {
        //                        var _GetLineOfItems = GetLineOfItems.Where(x => x.OrderNum == lineitems.OrderNum);

        //                        //  lineitems.TotalLines = _GetLineOfItems.Count();
        //                        _LocalSaleOrderList.Add(lineitems);
        //                    }
        //                }
        //            }
        //        }
        //    }



        //}






        public async Task<List<OrderDetailModel>> GetEpicorOrderDetailsAsync(string[] Orders)
        {
            List<OrderDetailModel> _OrderLines = null;

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    // var data = JsonConvert.DeserializeObject<string[]>(Orders);
                    ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(Constant.EpicorApi_OrderDetails, "GET");
                    if (ObjResponse.success == true)
                    {
                        var _result = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
                        if (_result.ContainsKey("value"))
                        {
                            if (!String.IsNullOrEmpty(_result["value"].ToString()))
                            {
                                _OrderLines = JsonConvert.DeserializeObject<List<OrderDetailModel>>(_result["value"].ToString());
                                if (_OrderLines != null) _OrderLines = _OrderLines.Where(x => Orders.Contains(x.OrderNum.ToString())).ToList();
                                foreach (var line in _OrderLines)
                                {
                                    // _Order.BinNum = GetPartBinLocation(_PObjResponse, Objbinnum, retobj, _Order);
                                    line.ImageContent = await GetItemImageByPartNumberAsync(line.PartNum);
                                }


                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                var message = ex.Message.ToString();
            }

            return _OrderLines;
        }
        public async Task<string> GetPartBinLocationAsync(OrderDetailModel _Order)
        {
            ResponseModel _Response;
            Dictionary<string, object> _Result;
            Dictionary<string, object> retobj;
            _Response = await _apiResponse.GetApiResponseAsync(Constant.PartBinSearchSvc, "POST", "{\"partNum\":'" + _Order.PartNum + "',\"whseCode\":''}");
            if (_Response.success)
            {
                _Result = JsonConvert.DeserializeObject<Dictionary<string, object>>(_Response.Response);

                //var _resultbinnum1 = JsonConvert.DeserializeObject<List<OrderDetModel>>(_PObjResponse.Response);
                if (_Result.ContainsKey("returnObj"))
                {
                    if (!String.IsNullOrEmpty(_Result["returnObj"].ToString()))
                    {
                        retobj = JsonConvert.DeserializeObject<Dictionary<string, object>>(_Result["returnObj"].ToString());
                        if (retobj.ContainsKey("PartBinSearch"))
                        {
                            var partBinList = JsonConvert.DeserializeObject<List<PartBinModel>>(retobj["PartBinSearch"].ToString()).FirstOrDefault();
                            if (partBinList != null)
                            {
                                return partBinList.BinNum;

                            }
                        }
                    }
                }
            }
            return string.Empty;
        }
        public async Task<string> GetItemImageByPartNumberAsync(string partNum)
        {
            using (_apiResponse = new ApiResponse())
            {
                ResponseModel ObjResponse = await _apiResponse.GetApiResponseAsync(Constant.EpicorApi_PartImage, "GET");



                return string.Empty;
            }
        }

       
    }
}
