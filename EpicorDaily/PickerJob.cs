using DotCommon;
using EpicorDaily.Model;
using EpicorDaily.Persistance.Repository;
using EpicorDaily.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily
{


    public class PickerJob
    {
        private static PickerRepository _pickerRepository;
        private static ApiResponse _apiResponse;
        private static StackTrace _stackTrace = new StackTrace();


        public static void SyncEpicorPickers()
        {
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();
                using (_apiResponse = new ApiResponse())
                {

                    var request = JsonConvert.SerializeObject(new { whereClause = "GroupList Like '%WHSE%'", pageSize = 0, absolutePage = 0 });


                    var response = _apiResponse.GetApiResponse(Constant.EpicorApi_PickerList, "POST", request);
                    if (!response.success) { DLog.Log(string.Format("Epicor api Service failed to response " + Constant.EpicorApi_PickerList, PickerUserGroup.WHSE.ToString())); return; }
                    var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Response);


                    if (!data.ContainsKey("returnObj") || String.IsNullOrEmpty(data["returnObj"].ToString())) DLog.Log(string.Format("No object return from Epicor Api- " + Constant.EpicorApi_PickerList, PickerUserGroup.WHSE.ToString()));
                    var returnObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(data["returnObj"].ToString());
                    if (!returnObj.ContainsKey("UserFileList") || String.IsNullOrEmpty(returnObj["UserFileList"].ToString())) DLog.Log(string.Format("No UserFileList return from Epicor Api- " + Constant.EpicorApi_PickerList, PickerUserGroup.WHSE.ToString()));

                    var pickerlist = JsonConvert.DeserializeObject<List<PickerModel>>(returnObj["UserFileList"].ToString());
                    // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                    if (pickerlist == null) { DLog.Log("No picker found"); return; }
                    using (_pickerRepository = new PickerRepository(_stackTrace))
                    {
                        _pickerRepository.SaveEpicorPickers(pickerlist);
                        DLog.Log("Epicor Picker user sync successfully");
                    }

                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error in Synchronizing Epicor Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);

            }
        }
        private static List<OrderDetailModel> GetOrderLineItem(string company, int orderNum)
        {


            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                DLog.Log("Get OrderRelationByOrdernum for OrderNum :" + company);
                using (_apiResponse = new ApiResponse())
                {
                    string uri = string.Format(Constant.EpicorApi_OrderLineItems, company, orderNum);
                    DLog.Log("Calling Epicor api :" + uri);

                    var _response = _apiResponse.GetApiResponse(uri, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + uri);
                        return null;
                    }

                    else
                    {
                        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                        if (_data.ContainsKey("value"))
                        {

                            if (!String.IsNullOrEmpty(_data["value"].ToString()))
                            {

                                var _result2 = _data["value"];

                                var _result = JsonConvert.DeserializeObject<List<OrderDetailModel>>(_data["value"].ToString());


                                return _result;
                            }

                        }
                        DLog.Log("Epicor api return 0 record");
                        return null;
                        //return JsonConvert.DeserializeObject<OrderRelDataTable>("[" + _data[1.ToString()] + "]");
                        // return JsonConvert.DeserializeObject<OrderRelDataTable>("[" + _result + "]");

                    }
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error in Getting Epicor Epicor Order Lines: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return null;
            }
        }

        public static bool SyncEpicorOrders()
        {
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                var orders = GetEpicorOrders();

                if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");
                using (_pickerRepository = new PickerRepository(_stackTrace))
                {
                    _pickerRepository.SaveEpicorOrders(orders);
                    return true;
                }

            }
            catch (Exception ex)
            {
                DLog.Log("Error in Synchronizing Epicor Orders: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return false;
            }
        }


        public static List<OrderHeadModel> GetEpicorOrders()
        {

            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                int lastorderno = 0;
                using (_pickerRepository = new PickerRepository(_stackTrace))
                {
                    List<OrderHeadModel> pickerOrder = _pickerRepository.GetDotItOrder();
                    using (_apiResponse = new ApiResponse())
                    {

                        if (pickerOrder != null) lastorderno = pickerOrder.Max(f => f.OrderNum);
                        DLog.Log("Calling Epicor api :" + Constant.EpicorApi_SalesOrder);
                        var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "Get");
                        if (!_response.success)
                        {
                            DLog.Log("Epicor api failed  " + Constant.EpicorApi_SalesOrder);
                            return null;
                        }

                        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                        if (_data.ContainsKey("value"))
                        {

                            if (!String.IsNullOrEmpty(_data["value"].ToString()))
                            {
                                var _result = JsonConvert.DeserializeObject<List<OrderHeadModel>>(_data["value"].ToString());

                                var picker = _pickerRepository.GetPickers();

                                _result.ForEach(f =>
                                {
                                    DLog.Log("Comp:" + f.Company + " Order#" + f.OrderNum + " Weight: " + f.Weight);
                                    f.Weight = GetOrderLineItem(f.Company, f.OrderNum).Sum(s => s.NetWeight_c);
                                    f.PickerUserId = (f.Weight > 0) ? GetAssignedPicker(f, picker, pickerOrder) : string.Empty;
                                });

                                DLog.Log("Epicor api return records  " + _result.Count);
                                return _result;
                            }
                        }

                    }
                }

                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Error in getting Epicor Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return null;
            }
        }

        private static string GetAssignedPicker(OrderHeadModel order, List<PickerModel> picker, List<OrderHeadModel> pickerOrder)
        {
            string dcduserid = string.Empty;
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                using (_pickerRepository = new PickerRepository(_stackTrace))
                {
                    // var picker = _pickerRepository.GetPickers();


                    var pickerorderweight = 0.0; var pickerMaxLine = 0;
                    List<OrderHeadModel> pickorderdata;
                    picker.ForEach(f =>
                    {
                        pickorderdata = pickerOrder.Where(w => (w.PickerUserId.Equals(f.DcdUserID)) && !w.OrderPickStatus.Equals(PickerOrderStatus.Picked.ToString())).ToList();
                        if (pickerOrder != null && pickerOrder.Count() > 0)
                        {
                            pickerorderweight = pickorderdata.Sum(s => s.Weight);

                            pickerMaxLine = pickorderdata.Sum(s => s.TotalLines);
                            if ((order.Weight < (f.MaxWeight - pickerorderweight)) && order.TotalLines < pickerMaxLine) { dcduserid = f.DcdUserID; return; }
                        }
                // if (pickerOrder != null && pickerOrder.Count() > 0) pickerPendingWeight = pickerOrder.Sum(F => F.Weight);

            });

                }
            }
            catch (Exception ex)
            {

                DLog.Log("Error in setting Assigned Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return dcduserid;
        }




    }
}
