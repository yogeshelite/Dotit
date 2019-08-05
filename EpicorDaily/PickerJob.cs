using DotCommon;
using EpicorDaily.Model;
using EpicorDaily.Persistance.Repository;
using EpicorDaily.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily
{


    class PickerJob
    {
        private static PickerRepository _pickerRepository;
        private static ApiResponse _apiResponse;

        public static void SyncEpicorPickers()
        {
            try
            {
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
                    using (_pickerRepository = new PickerRepository())
                    {
                        _pickerRepository.SyncEpicorPickers(pickerlist);
                        DLog.Log("Epicor Picker user sync successfully");
                    }

                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();
                }
            }
            catch (Exception ex)
            {

                DLog.Log("Error in Getting Epicor Picker users: " + ex.Message, memberName: "SyncEpicorPickers");
            }
        }


        public void SyncEpicorOrders()
        {
            try
            {
                var orders = GetEpicorOrders();

                if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");
                using (_pickerRepository = new PickerRepository())
                {

                    _pickerRepository.SyncEpicorOrders(orders);



                }

            }
            catch (Exception ex)
            {
                DLog.Log("Error in Getting Epicor Picker users: " + ex.Message, memberName: "SyncEpicorPickers");
            }
        }


        public List<OrderHeadModel> GetEpicorOrders()
        {
            DLog.Log("GetWebOrder");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
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
                            DLog.Log("Epicor api return records  " + _result.Count);
                            return _result;
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetWebOrder : " + ex.Message);
                return null;
            }
        }
        public void AssignOrdersToPicker()
        {
            //try
            //{
            //    //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();
            //    using (_apiResponse = new ApiResponse())
            //    {
            //        var _response = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_PickerList, PickerUserGroup.WHSE.ToString()), "POST");
            //        if (!_response.success) { DLog.Log(string.Format("Epicor api Service failed to response " + Constant.EpicorApi_PickerList, PickerUserGroup.WHSE.ToString())); return; }
            //        var pickerlist = JsonConvert.DeserializeObject<List<WAREHOUSEEMPLOYEE>>(_response.Response);
            //        // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

            //        if (pickerlist == null) { DLog.Log("No picker  can not desealize "); return; }
            //        using (_dotitExtDataContext = new DotitExtensionEntities())
            //        {

            //            WAREHOUSEEMPLOYEE picker;
            //            foreach (var list in pickerlist)
            //            {
            //                picker = _dotitExtDataContext.WAREHOUSEEMPLOYEEs.FirstOrDefault(f => f.DOCUSERID.Equals(list.DOCUSERID));
            //                if (picker != null)
            //                {
            //                    picker.EMAILADDRESS = list.EMAILADDRESS;
            //                    picker.GROUPLIST = list.GROUPLIST;
            //                    picker.PICKERNAME = list.PICKERNAME;
            //                    picker.RECORDUPDATEDATE = list.RECORDUPDATEDATE;
            //                }
            //                else
            //                {
            //                    _dotitExtDataContext.WAREHOUSEEMPLOYEEs.Add(list);
            //                }
            //            }
            //            DLog.Log("Epicor Picker user sync successfully");
            //        }
            //        //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    DLog.Log("Error No picker  can not desealize ");
            //}
        }
    }
}
