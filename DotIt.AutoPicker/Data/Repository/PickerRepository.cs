//using DotCommon;
using DotIt.AutoPicker.Data.DotIt;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Services;


//using DotIt.AutoPicker.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DotIt.AutoPicker.Persistance.Repository
{

    public interface IPickerRepository : IDisposable
    {
        bool SaveEpicorPickers(List<PickerModel> pickerlist);
        void SaveEpicorOrders(List<OrderHeadModel> orders);
        List<PickerModel> GetPickers(string company = null, string docuserid = null);

        List<OrderHeadModel> GetDotItOrder(string company = null, string docuserid = null, string NotEqualOrderStatus = null);
        void DotitOrderPickerUpdate(int ordernum, string orderstatus, string resionPickFail, string partno, int itemstatus);
        List<OrderDetailModel> GetDotItOrderDetails(int[] orderno = null, string docuserid = null);
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
        DotitExtensionContext _dotitExtDataContext;
        public bool SaveEpicorPickers(List<PickerModel> pickerlist)
        {
            try
            {
                //  DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                if (pickerlist == null) { return false; }
                using (_dotitExtDataContext = new DotitExtensionContext())
                {

                    Warehouseemployee picker;
                    var newpickerlist = pickerlist.Where(p => !_dotitExtDataContext.Warehouseemployee.Any(f => f.Dcduserid.Equals(p.DcdUserID))).ToList();
                    var existingpickerlist = pickerlist.Where(p => _dotitExtDataContext.Warehouseemployee.Any(f => f.Dcduserid.Equals(p.DcdUserID))).ToList();
                    foreach (var list in newpickerlist)
                    {
                        picker = new Warehouseemployee()
                        {
                            Emailaddress = list.EMailAddress,
                            Grouplist = list.Grouplist,
                            Pickername = list.Name,
                            Recorddate = DateTime.Now,
                            Dcduserid = list.DcdUserID,
                            Password = "pik" + Guid.NewGuid().ToString().Substring(0, 8),
                            active = true
                        };
                        _dotitExtDataContext.Warehouseemployee.Add(picker);

                    }
                    // _dotitExtDataContext.SaveChanges();

                    foreach (var list in existingpickerlist)
                    {
                        picker = _dotitExtDataContext.Warehouseemployee.FirstOrDefault(f => f.Dcduserid.Equals(list.DcdUserID));
                        if (picker != null)
                        {
                            picker.Emailaddress = list.EMailAddress;
                            picker.Grouplist = list.Grouplist;
                            picker.Pickername = list.Name;
                            picker.Recordupdatedate = DateTime.Now;

                        }
                    }
                    _dotitExtDataContext.SaveChanges();
                }

                // DLog.Log("Epicor Picker user sync successfully");
                return true;
                //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

            }
            catch (Exception ex)
            {

                // DLog.Log("Error in saving Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return false;
            }
        }




        public void DotitOrderPickerUpdate(int ordernum, string orderstatus, string resionPickFail ,string partno,int itemstatus)
        {
            try
            {

                using (_dotitExtDataContext = new DotitExtensionContext())
                {
                    //var dotitOrder = _dotitExtDataContext.Pickerorder.ToList();
                    //List<Pickerorder> pickerOrder = orders.Where(f => !dotitOrder.Any(o => o.Company.Equals(f.Company) & o.Ordernum.Equals(f.OrderNum))).Select(f => new Pickerorder()
                    //{
                    //    Ordernum = f.OrderNum,
                    //    Company = f.Company,
                    //    Orderdate = f.OrderDateTime,
                    //    Totalitems = f.TotalLines,
                    //    Weight = f.Weight,
                    //    Recorddate = DateTime.Now,
                    //    Pickstatus = string.IsNullOrEmpty(f.PickerUserId) ? PickerOrderStatus.AssignPending.ToString() : PickerOrderStatus.Assigned.ToString(),
                    //    Dcduserid = f.PickerUserId

                    //}).ToList();
                    //List <OrderHeadModel> ordersList = GetDotItOrder(null,null).Where(x => x.OrderNum == ordernum).ToList();

                    //
                    //if (ordersList != null)
                    //{
                    
                    
                    //Pickerorder objPickerOrder = _dotitExtDataContext.Pickerorder.FirstOrDefault(x => x.Ordernum == ordernum);
                    //if (objPickerOrder != null)
                    //{
                    //    objPickerOrder.Pickstatus = orderstatus;
                    //    objPickerOrder.Recordupdatedon = DateTime.Now;
                    //    objPickerOrder.ReasionPickFail = "NO";
                    //    _dotitExtDataContext.SaveChanges();

                    //}

                    Pickorderdetail objPickerOrderDetail = _dotitExtDataContext.Pickorderdetail.FirstOrDefault(x => x.Orderno == ordernum && x.Partnum == partno);
                    if (objPickerOrderDetail != null)
                    {
                        objPickerOrderDetail.Pickstatus = itemstatus;
                        _dotitExtDataContext.SaveChanges();

                    }
                }

            }
            catch (Exception ex)
            {
                // DLog.Log("Error in saving Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
        }
        public void SaveEpicorOrders(List<OrderHeadModel> orders)
        {
            try
            {
                //DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                // var orders = GetOrderHead();

                // if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");
                using (_dotitExtDataContext = new DotitExtensionContext())
                {
                    var dotitOrder = _dotitExtDataContext.Pickerorder.ToList();
                    List<Pickerorder> pickerOrder = orders.Where(f => !dotitOrder.Any(o => o.Company.Equals(f.Company) & o.Ordernum.Equals(f.OrderNum))).Select(f => new Pickerorder()
                    {
                        Ordernum = f.OrderNum,
                        Company = f.Company,
                        Orderdate = f.OrderDateTime,
                        Totalitems = f.TotalLines,
                        Weight = f.Weight,
                        Recorddate = DateTime.Now,
                        Pickstatus = string.IsNullOrEmpty(f.PickerUserId) ? PickerOrderStatus.AssignPending.ToString() : PickerOrderStatus.Assigned.ToString(),
                        Dcduserid = f.PickerUserId

                    }).ToList();

                    _dotitExtDataContext.Pickerorder.AddRange(pickerOrder);

                    _dotitExtDataContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                // DLog.Log("Error in saving Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
        }



        public List<PickerModel> GetPickers(string company = null, string docuserid = null)
        {
            List<PickerModel> result = null;
            try
            {
                //DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionContext())
                {


                    var pickers = _dotitExtDataContext.Warehouseemployee.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid)).ToList();


                    result = pickers.Select(f => new PickerModel()
                    {
                        EMailAddress = f.Emailaddress,
                        Grouplist = f.Grouplist,
                        Name = f.Pickername,
                        RecordDate = f.Recorddate,
                        DcdUserID = f.Dcduserid,
                        //EmpID = f.EMPID,
                        Active = f.active,
                        AdminlineperHour = f.Adminlineperhour,
                        LastLogin = f.Lastlogin,
                        MaxLines = f.Maxlines,
                        MaxWeight = f.Maxweight,
                        UserHeight = f.UserHeight,
                        WeightCapacity = f.WeightCapacity
                    }).ToList();




                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Getting Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }
        // OrderHeadModel to  Pickerorder  Puneet Change 20190821 

        public List<OrderHeadModel> GetDotItOrder(string company = null, string docuserid = null, string NotEqualOrderStatus = null)
        {
            List<OrderHeadModel> result = null;
            try
            {
                // DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionContext())
                {
                    // var data = _dotitExtDataContext.Pickerorder.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));
                    //var data = _dotitExtDataContext.Pickerorder.ToList();//.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));



                    result = _dotitExtDataContext.Pickerorder.Where(x => x.Dcduserid == docuserid && x.Pickstatus != NotEqualOrderStatus).Select(f => new OrderHeadModel()
                    {
                        OrderNum = f.Ordernum,
                        Company = f.Company,
                        OrderDateTime = f.Orderdate,
                        TotalLines = f.Totalitems.Value,
                        Weight = f.Weight.Value,
                        PickerUserId = f.Dcduserid,
                        OrderPickStatus = f.Pickstatus,
                        RequestDate = f.Recorddate.Value,
                        PickDate = f.PickDate.Value


                    }).ToList();




                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }
        public List<OrderDetailModel> GetDotItOrderDetails(int[] orderno = null, string docuserid = null)
        {
            List<OrderDetailModel> result = null;
            try
            {
                // DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                using (_dotitExtDataContext = new DotitExtensionContext())
                {
                    // var data = _dotitExtDataContext.Pickerorder.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));
                    //var data = _dotitExtDataContext.Pickerorder.ToList();//.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));



                    result = _dotitExtDataContext.Pickorderdetail.Where(x => orderno.Contains(x.Orderno) && x.Pickstatus==6).Select(f => new OrderDetailModel()
                    {
                        OrderNum = f.Orderno,
                        Company = f.Company,
                        PartNum = f.Partnum,
                        BinNum = f.Binnum,
                        OrderLineStatusCode = f.Pickstatus.ToString(),
                        LineDesc = f.LineDesc,
                        OrderQty = (float)f.OrderQty


                    }).ToList();




                    //user = user.Where(f => enumlist.Any(e => f.GroupList.Split('~').Contains(e))).ToList();

                }
            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
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
