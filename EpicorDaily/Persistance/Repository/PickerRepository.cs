using DotCommon;
using EpicorDaily.Model;
using EpicorDaily.Persistance.Data;

using EpicorDaily.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EpicorDaily.Persistance.Repository
{

    public interface IPickerRepository : IDisposable
    {
        bool SyncEpicorPickers(List<PickerModel> pickerlist);
        void SyncEpicorOrders(List<OrderHeadModel> orders);
        List<PickerModel> GetPicker();
    }

    public class PickerRepository : IPickerRepository
    {


        #region Picker Mangement
        //public List<PickerUserModel> GetEpicorPickers()
        //{
        //    ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, objModel.Username), "GET");
        //    var user = JsonConvert.DeserializeObject<UserFile>(ObjResponse.Response);

        //}
        DotitExtensionEntities _dotitExtDataContext;
        public bool SyncEpicorPickers(List<PickerModel> pickerlist)
        {
            try
            {
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                if (pickerlist == null) { DLog.Log("No picker  can not desealize "); return false; }
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

                DLog.Log("Error in Getting Epicor Picker users: " + ex.Message, memberName: "SyncEpicorPickers");
                return false;
            }
        }


        public void SyncEpicorOrders(List<OrderHeadModel> orders)
        {
            try
            {
                // var orders = GetOrderHead();
                var dotitOrder = _dotitExtDataContext.PICKERORDERs.ToList();
                if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");
                using (_dotitExtDataContext = new DotitExtensionEntities())
                {
                    List<PICKERORDER> pickers = orders.Where(f => !dotitOrder.Any(o => o.COMPANY.Equals(f.Company) & o.ORDERNUM.Equals(f.OrderNum))).Select(f => new PICKERORDER()
                    {
                        COMPANY = f.Company,
                        ORDERDATE = f.OrderDateTime,
                        TOTALITEMS = f.TotalLines,
                        WEIGHT = f.Weight,
                        RECORDDATE = DateTime.Now


                    }).ToList();




                }

            }
            catch (Exception ex)
            {
                DLog.Log("Error in Getting Epicor Picker users: " + ex.Message, memberName: "SyncEpicorPickers");
            }
        }



        public List<PickerModel> GetPickers(string company, string docuserid)
        {
            List<PickerModel> result = null;
            try
            {
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionEntities())
                {


                    result = _dotitExtDataContext.WAREHOUSEEMPLOYEEs.Where(f => (string.IsNullOrEmpty(company) | f.COMPANY.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.DCDUSERID.Equals(docuserid)).Select(f => new PickerModel()
                    {
                        EMailAddress = f.EMAILADDRESS,
                        Grouplist = f.GROUPLIST,
                        Name = f.PICKERNAME,
                        RecordDate = f.RECORDDATE,
                        DcdUserID = f.DCDUSERID,
                        EmpID = f.EMPID,
                        Active = f.ACTIVE.Value,
                        AdminlineperHour = f.ADMINLINEPERHOUR.Value,
                        LastLogin = f.LASTLOGIN,
                        MaxLines = f.MAXLINES.Value,
                        MaxWeight = f.MAXWEIGHT.Value
                    }).ToList();


                    DLog.Log("Epicor Picker user sync successfully");

                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error No picker  can not desealize ");
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

        public List<PickerModel> GetPicker()
        {
            throw new NotImplementedException();
        }
        #endregion




        #endregion

    }
}
