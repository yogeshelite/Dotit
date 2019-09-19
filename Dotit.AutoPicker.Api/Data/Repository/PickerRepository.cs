using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.UnitOfWork;
using DotIt.AutoPickerApi.Models;
using DotIt.AutoPickerApi.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Persistance.Repository
{

    public interface IPickerRepository : IDisposable
    {
        Task<bool> SaveEpicorPickersAsync(List<PickerModel> pickerlist);
        Task<bool> SaveEpicorOrdersAsync(List<OrderHeadModel> orders);
        Task<List<PickerModel>> GetPickersAsync(string company = null, string dcduserid = null);

        Task<List<OrderHeadModel>> GetDotItOrderAsync(string company = null, string docuserid = null);
        Task<List<OrderHeadModel>> GetDotItOrderByOrderNoAsync(string NotEqualOrderStatus = null, int? orderno = null);
        Task<string> UpdateDotitPickerOrderAsync(int ordernum, string orderstatus, string resionPickFail, string partno, int itemstatus);

        Task<bool> OrderCompleteOrNotAsync(int ordernum);
        Task<List<OrderDetailModel>> GetDotItOrderDetailsAsync(int[] orderno = null, string docuserid = null, int statuscode = 0);
        Task<bool> AddPickerOrderAsync(OrderHeadModel orderHeadModel);
        Task<bool> UpdateProfileAsync(PickerModel pickerModel);
        bool AddOrderLines(List<OrderDetailModel> orderDtls);
    }

    public class PickerRepository : IPickerRepository
    {
        private StackTrace _StackTrace;
        private DotitExtensionContext _DotitExtDataContext;
        private IUnitOfWork _UnitOfWork;
        public PickerRepository(StackTrace stackTrace, DotitExtensionContext dotitExtDataContext, IUnitOfWork unitOfWork)
        {
            _StackTrace = stackTrace;
            _DotitExtDataContext = dotitExtDataContext;
            _UnitOfWork = unitOfWork;
        }
        #region Picker Mangement
        //public List<PickerUserModel> GetEpicorPickers()
        //{
        //    ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi.AuthPicker, objModel.Username), "GET");
        //    var user = JsonConvert.DeserializeObject<UserFile>(ObjResponse.Response);

        //}

        public async Task<bool> SaveEpicorPickersAsync(List<PickerModel> pickerlist)
        {
            try
            {
                //  DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                //  var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                // var enumlist = Util.EnumToList<PickerUserGroup>().Select(f => f.ToString()).ToList();

                if (pickerlist == null) { return false; }
                //using (_DotitExtDataContext = new DotitExtensionContext())
                //{

                Warehouseemployee picker;
                var newpickerlist = pickerlist.Where(p => !_DotitExtDataContext.Warehouseemployee.Any(f => f.Dcduserid.Equals(p.DcdUserID))).ToList();
                var existingpickerlist = pickerlist.Where(p => _DotitExtDataContext.Warehouseemployee.Any(f => f.Dcduserid.Equals(p.DcdUserID))).ToList();
                await Task.Run(() =>
                 {
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
                             Active = true
                         };
                         _DotitExtDataContext.Warehouseemployee.Add(picker);

                     }
                 });
                // _dotitExtDataContext.SaveChanges();
                await Task.Run(() =>
                {
                    foreach (var list in existingpickerlist)
                    {
                        picker = _DotitExtDataContext.Warehouseemployee.FirstOrDefault(f => f.Dcduserid.Equals(list.DcdUserID));
                        if (picker != null)
                        {
                            picker.Emailaddress = list.EMailAddress;
                            picker.Grouplist = list.Grouplist;
                            picker.Pickername = list.Name;
                            picker.Recordupdatedate = DateTime.Now;

                        }
                    }
                });
                _DotitExtDataContext.SaveChanges();
                //}

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
        public async Task<bool> OrderCompleteOrNotAsync(int ordernum)
        {
            string orderstatus = string.Empty;
            Pickerorder objPickerOrderUpdate = _DotitExtDataContext.Pickerorder.FirstOrDefault(x => x.Ordernum == ordernum);
            if (objPickerOrderUpdate != null)
            {
                var pendingPicklines = await GetDotItOrderDetailsAsync(new int[1] { ordernum }, null, (int)LineItemStatus.Pending);
                if (pendingPicklines.LongCount() == 0)
                {

                    objPickerOrderUpdate.Pickstatus = OrderStatus.Complete.ToString();
                    _DotitExtDataContext.SaveChanges();
                    return true;
                }
            }
            return false;


        }

        public async Task<string> UpdateDotitPickerOrderAsync(int ordernum, string orderstatus, string resionPickFail, string partno, int itemstatus)
        {
            try
            {


                var pickerOrder = await _DotitExtDataContext.Pickerorder.FirstOrDefaultAsync(f => f.Ordernum.Equals(ordernum));
                if (pickerOrder != null)
                {
                    Pickorderdetail objPickerOrderDetail = await _DotitExtDataContext.Pickorderdetail.FirstOrDefaultAsync(x => x.Ordernum == ordernum && x.Partnum == partno);
                    if (objPickerOrderDetail != null)
                    {
                        objPickerOrderDetail.Pickstatus = itemstatus;
                        _DotitExtDataContext.SaveChanges();
                        var pendingPicklines = await GetDotItOrderDetailsAsync(new int[1] { ordernum }, null, (int)LineItemStatus.Pending);
                        if (pendingPicklines.LongCount() == 0)
                        {

                            pickerOrder.Pickstatus = OrderStatus.Complete.ToString();
                            _DotitExtDataContext.SaveChanges();
                            return OrderStatus.Complete.ToString();
                        }

                    }
                }


                return OrderStatus.Pending.ToString();

            }
            catch (Exception ex)
            {
                return OrderStatus.Pending.ToString();
                // DLog.Log("Error in saving Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
        }
        public async Task<bool> SaveEpicorOrdersAsync(List<OrderHeadModel> orders)
        {
            try
            {
                //DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                // var orders = GetOrderHead();

                // if (orders == null) DLog.Log("No Order found in Epicor assign to picker user");

                var dotitOrder = await _DotitExtDataContext.Pickerorder.ToListAsync();
                List<Pickerorder> pickerOrder = orders.Where(f => !dotitOrder.Any(o => o.Company.Equals(f.Company) & o.Ordernum.Equals(f.OrderNum))).Select(f => new Pickerorder()
                {
                    Ordernum = f.OrderNum,
                    Company = f.Company,
                    Orderdate = f.OrderDateTime,
                    Totalitems = f.TotalLines,
                    Weight = f.Weight,
                    Recorddate = DateTime.Now,
                    Pickstatus = string.IsNullOrEmpty(f.PickerUserId) ? OrderStatus.Pending.ToString() : OrderStatus.Assigned.ToString(),
                    Dcduserid = f.PickerUserId

                }).ToList();

                _DotitExtDataContext.Pickerorder.AddRange(pickerOrder);

                _DotitExtDataContext.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                // DLog.Log("Error in saving Order: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
                return false;
            }
        }

        public async Task<List<PickerModel>> GetPickersAsync(string company = null, string dcduserid = null)
        {
            List<PickerModel> result = null;
            try
            {
                //DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);


                var pickers = await _DotitExtDataContext.Warehouseemployee.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(dcduserid) | f.Dcduserid.Equals(dcduserid)).ToListAsync();
                result = pickers.Select(f => new PickerModel()
                {
                    EMailAddress = f.Emailaddress,
                    Grouplist = f.Grouplist,
                    Name = f.Pickername,
                    RecordDate = f.Recorddate,
                    DcdUserID = f.Dcduserid,
                    //EmpID = f.EMPID,
                    Active = f.Active,
                    AdminlineperHour = f.Adminlineperhour,
                    LastLogin = f.Lastlogin,
                    MaxLines = f.Maxlines,
                    MaxWeight = f.Maxweight,
                    UserHeight = f.Userheight,
                    WeightCapacity = f.Weightcapacity,
                    MaxOrder = f.Maxorder
                }).ToList();

            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Getting Picker: " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }
        // OrderHeadModel to  Pickerorder  Puneet Change 20190821 

        public async Task<List<OrderHeadModel>> GetDotItOrderAsync(string company = null, string docuserid = null)
        {
            List<OrderHeadModel> result = null;
            try
            {
                // DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);

                result = await _DotitExtDataContext.Pickerorder.Where(x => (string.IsNullOrEmpty(docuserid) | x.Dcduserid == docuserid)).Select(f => new OrderHeadModel()
                {
                    OrderNum = f.Ordernum,
                    Company = f.Company,
                    OrderDateTime = f.Orderdate,

                    TotalLines = f.Totalitems.Value, //_dotitExtDataContext.Pickorderdetail.Where (x=>x.Orderno.Equals(f.Ordernum) & x.Company.Equals(f.Company)).Count(),
                    Weight = f.Weight.Value,
                    PickerUserId = f.Dcduserid,
                    OrderPickStatus = f.Pickstatus,
                    RequestDate = f.Recorddate.Value,
                    PickDate = f.Pickdate.Value


                }).ToListAsync();
            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }
        public async Task<List<OrderHeadModel>> GetDotItOrderByOrderNoAsync(string NotEqualOrderStatus = null, int? orderno = null)
        {
            List<OrderHeadModel> result = null;
            try
            {

                result = await _DotitExtDataContext.Pickerorder.Where(x => x.Pickstatus != NotEqualOrderStatus && x.Ordernum == orderno).Select(f => new OrderHeadModel()
                {
                    OrderNum = f.Ordernum,
                    Company = f.Company,
                    OrderDateTime = f.Orderdate,
                    // TotalLines = f.Totalitems.Value,
                    Weight = f.Weight.Value,
                    PickerUserId = f.Dcduserid,
                    OrderPickStatus = f.Pickstatus,
                    RequestDate = f.Recorddate.Value,
                    PickDate = f.Pickdate.Value


                }).ToListAsync();


            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }


        public bool AddOrderLines(List<OrderDetailModel> orderDtls)
        {
            return Parallel.ForEach(orderDtls, (f) =>
             {
                 _DotitExtDataContext.Pickorderdetail.AddAsync(new Pickorderdetail()
                 {
                     Binnum = f.BinNum,
                     Company = f.Company,
                     Ordernum = f.OrderNum,
                     Partnum = f.PartNum,
                     Damageqty = 0,
                     Pickstatus = 6,
                     Orderline = f.OrderLine,
                     Orderqty = (decimal)f.OrderQty,
                     Ium = f.IUM,
                     Linedesc = f.LineDesc,
                     Unitprice = (decimal)f.UnitPrice,
                     Totalprice = (decimal)f.TotalPrice
                 });
             }).IsCompleted;
        }
        public async Task<List<OrderDetailModel>> GetDotItOrderDetailsAsync(int[] orderno = null, string docuserid = null, int statuscode = 0)
        {
            List<OrderDetailModel> result = null;
            try
            {
                // DLog.Log("Calling Method: " + _stackTrace.GetFrame(1).GetMethod().Name);
                // var data = _dotitExtDataContext.Pickerorder.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));
                //var data = _dotitExtDataContext.Pickerorder.ToList();//.Where(f => (string.IsNullOrEmpty(company) | f.Company.Equals(company)) & string.IsNullOrEmpty(docuserid) | f.Dcduserid.Equals(docuserid));


                result = await _DotitExtDataContext.Pickorderdetail.Where(x => orderno.Contains(x.Ordernum) && ((statuscode == 0) | x.Pickstatus == 6)).Select(f => new OrderDetailModel()
                {
                    OrderDetailID = f.Id,
                    OrderNum = f.Ordernum,
                    Company = f.Company,
                    PartNum = f.Partnum,
                    BinNum = f.Binnum,
                    OrderLineStatusCode = f.Pickstatus.ToString(),
                    LineDesc = f.Linedesc,
                    OrderQty = (float)f.Orderqty,


                }).ToListAsync();

            }
            catch (Exception ex)
            {
                //DLog.Log("Error in Fetching Dotit Order : " + ex.Message, memberName: _stackTrace.GetFrame(1).GetMethod().Name);
            }
            return result;
        }
        public async Task<bool> UpdateProfileAsync(PickerModel pickerModel)
        {
            try
            {
                var picker = await _DotitExtDataContext.Warehouseemployee.FirstOrDefaultAsync(x => x.Dcduserid.Equals(pickerModel.DcdUserID));
                if (picker != null)
                {
                    picker.Emailaddress = pickerModel.EMailAddress;
                    picker.Grouplist = pickerModel.Grouplist.Replace('~', ',');
                    picker.Pickername = pickerModel.Name;
                    picker.Recorddate = pickerModel.RecordDate;
                    //DcdUserID = pickerModel.Dcduserid;
                    //EmpID = pickerModel.EMPID;
                    picker.Active = pickerModel.Active;
                    picker.Adminlineperhour = pickerModel.AdminlineperHour;
                    picker.Lastlogin = pickerModel.LastLogin;
                    picker.Maxlines = pickerModel.MaxLines;
                    picker.Maxweight = pickerModel.MaxWeight;
                    picker.Userheight = pickerModel.UserHeight;
                    picker.Weightcapacity = pickerModel.WeightCapacity;
                    picker.Maxorder = pickerModel.MaxOrder;
                    //_DotitExtDataContext.SaveChanges();
                    _UnitOfWork.SaveDotitChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }

        }
        public async Task<bool> AddPickerOrderAsync(OrderHeadModel order)
        {
            Pickerorder objPicker = new Pickerorder();
            objPicker.Company = order.Company;
            objPicker.Ordernum = order.OrderNum;
            //objPicker.Ordernum = itemhm.OrderNum;
            objPicker.Orderdate = Convert.ToDateTime(order.OrderDate);
            objPicker.Totalitems = order.TotalLines;
            objPicker.Weight = order.TotalWgt_c;
            objPicker.Dcduserid = order.PickerUserId;
            objPicker.Pickdate = DateTime.Now;
            objPicker.Pickstatus = "Pending";
            objPicker.Recorddate = DateTime.Now;
            objPicker.Recordupdatedon = DateTime.Now;
            objPicker.Reasionpickfail = "NO";

            // Order  Save
            await _DotitExtDataContext.Pickerorder.AddAsync(objPicker);


            return true;
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
