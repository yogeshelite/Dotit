using DotCommon;
using EpicorDaily.Model;
using EpicorDaily.Persistance.Data;

using EpicorDaily.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EpicorDaily.Persistance.Repository
{

    public interface IPickerRepository : IDisposable
    {
        bool SaveEpicorPickers(List<PickerModel> pickerlist);
        void SaveEpicorOrders(List<OrderHeadModel> orders);
        List<PickerModel> GetPickers(string company = null, string docuserid = null);

        List<OrderHeadModel> GetDotItOrder(string company = null, string docuserid = null);
    }

    public class PickerRepository : IPickerRepository
    {
        private StackTrace _stackTrace;
        public PickerRepository(StackTrace stackTrace)
        {
            _stackTrace = stackTrace;
        }
        #region Picker Mangement
        //public List<PickerUserModel> GetEpicorPickers()
        //{
        //    ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, objModel.Username), "GET");
        //    var user = JsonConvert.DeserializeObject<UserFile>(ObjResponse.Response);

        //}
        DotitExtensionEntities _dotitExtDataContext;
        public bool SaveEpicorPickers(List<PickerModel> pickerlist)
        {
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                if (pickerlist == null) { return false; }
                using (_dotitExtDataContext = new DotitExtensionEntities())
                {

                    WAREHOUSEEMPLOYEE picker;
                    var newpickerlist = pickerlist.Where(p => !_dotitExtDataContext.WAREHOUSEEMPLOYEEs.Any(f => f.DCDUSERID.Equals(p.DcdUserID))).ToList();
                    var existingpickerlist = pickerlist.Where(p => _dotitExtDataContext.WAREHOUSEEMPLOYEEs.Any(f => f.DCDUSERID.Equals(p.DcdUserID))).ToList();
                    foreach (var list in newpickerlist)
                    {
                        picker = new WAREHOUSEEMPLOYEE()
                        {
                            EMAILADDRESS = list.EMailAddress,
                            GROUPLIST = list.Grouplist,
                            PICKERNAME = list.Name,
                            RECORDDATE = DateTime.Now,
                            DCDUSERID = list.DcdUserID,
                            PASSWORD = "pik" + Guid.NewGuid().ToString().Substring(0, 8),
                            ACTIVE = true
                        };
                        _dotitExtDataContext.WAREHOUSEEMPLOYEEs.Add(picker);

                    }
                   // _dotitExtDataContext.SaveChanges();

                    foreach (var list in existingpickerlist)
                    {
                        picker = _dotitExtDataContext.WAREHOUSEEMPLOYEEs.FirstOrDefault(f => f.DCDUSERID.Equals(list.DcdUserID));
                        if (picker != null)
                        {
                            picker.EMAILADDRESS = list.EMailAddress;
                            picker.GROUPLIST = list.Grouplist;
                            picker.PICKERNAME = list.Name;
                            picker.RECORDUPDATEDATE = DateTime.Now;

                        }
                    }
                    _dotitExtDataContext.SaveChanges();
                }

                DLog.Log("Epicor Picker user sync successfully");
                return true;
                //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

            }
            catch (Exception ex)
            {

                DLog.Log("Error in saving Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return false;
            }
        }


        public void SaveEpicorOrders(List<OrderHeadModel> orders)
        {
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                // var orders = GetOrderHead();

                if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");
                using (_dotitExtDataContext = new DotitExtensionEntities())
                {
                    var dotitOrder = _dotitExtDataContext.PICKERORDERs.ToList();
                    List<PICKERORDER> pickerOrder = orders.Where(f => !dotitOrder.Any(o => o.COMPANY.Equals(f.Company) & o.ORDERNUM.Equals(f.OrderNum))).Select(f => new PICKERORDER()
                    {
                        ORDERNUM = f.OrderNum,
                        COMPANY = f.Company,
                        ORDERDATE = f.OrderDateTime,
                        TOTALITEMS = f.TotalLines,
                        WEIGHT = f.Weight,
                        RECORDDATE = DateTime.Now,
                        PICKSTATUS = string.IsNullOrEmpty(f.PickerUserId) ? PickerOrderStatus.AssignPending.ToString() : PickerOrderStatus.Assigned.ToString(),
                        DCDUSERID = f.PickerUserId

                    }).ToList();

                    _dotitExtDataContext.PICKERORDERs.AddRange(pickerOrder);

                    _dotitExtDataContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                DLog.Log("Error in saving Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
        }



        public List<PickerModel> GetPickers(string company = null, string docuserid = null)
        {
            List<PickerModel> result = null;
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionEntities())
                {


                    var pickers = _dotitExtDataContext.WAREHOUSEEMPLOYEEs.Where(f => (string.IsNullOrEmpty(company) | f.COMPANY.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.DCDUSERID.Equals(docuserid)).ToList();


                    result = pickers.Select(f => new PickerModel()
                    {
                        EMailAddress = f.EMAILADDRESS,
                        Grouplist = f.GROUPLIST,
                        Name = f.PICKERNAME,
                        RecordDate = f.RECORDDATE,
                        DcdUserID = f.DCDUSERID,
                        EmpID = f.EMPID,
                        Active = f.ACTIVE,
                        AdminlineperHour = f.ADMINLINEPERHOUR,
                        LastLogin = f.LASTLOGIN,
                        MaxLines = f.MAXLINES,
                        MaxWeight = f.MAXWEIGHT
                    }).ToList();


     

                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error in Getting Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }

        public List<OrderHeadModel> GetDotItOrder(string company = null, string docuserid = null)
        {
            List<OrderHeadModel> result = null;
            try
            {
                DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionEntities())
                {


                    result = _dotitExtDataContext.PICKERORDERs.Where(f => (string.IsNullOrEmpty(company) | f.COMPANY.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.DCDUSERID.Equals(docuserid)).Select(f => new OrderHeadModel()
                    {
                        OrderNum = f.ORDERNUM,
                        Company = f.COMPANY,
                        OrderDateTime = f.ORDERDATE,
                        TotalLines = f.TOTALITEMS.Value,
                        Weight = f.WEIGHT.Value,
                        PickerUserId = f.DCDUSERID,
                        OrderPickStatus = f.PICKSTATUS,
                        RequestDate = f.RECORDDATE.Value,
                        PickDate = f.PICKDATE.Value


                    }).ToList();


                 

                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~PickerRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }




        #endregion




        #endregion

    }
}
