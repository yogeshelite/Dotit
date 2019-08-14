﻿using DotCommon;
using DotitBllDal;

using EpicorDaily.Model;
using EpicorDaily.Service;
using Erp.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Erp.BO.CustShipDataSet;
using static Erp.BO.SalesOrderDataSet;
using EpicorDaily.Persistance.Repository;
namespace EpicorDaily
{
    public class EpicorBusinessApi
    {
        ApiResponse _apiResponse;
      
        //public List<PickerUserModel> GetEpicorPickers()
        //{
        //    ResponseModel ObjResponse = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_AuthPicker, objModel.Username), "GET");
        //    var user = JsonConvert.DeserializeObject<UserFile>(ObjResponse.Response);

        //}
        // DotitExtensionEntities _dotitExtDataContext;
      
    




    


        /// <summary>
        /// GetReleaseOrder
        /// </summary>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        public List<OrderRelModel> GetReleaseOrder(int orderNum)
        {
            DLog.Log("GetReleaseOrder for orderNum: " + orderNum);

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_ReleaseOrders);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_ReleaseOrders, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_ReleaseOrders);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<List<OrderRelModel>>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  " + _result.Count);
                            return _result.Where(f => f.OrderNum.Equals(orderNum)).ToList();
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in ReleaseOrder : " + ex.Message);
                return null;
            }


        }

        public ShipHeadRow GetCustomerShip(int packNum, string company)
        {
            DLog.Log("GetCustomerShip for packNum :" + packNum);

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_CustomerShips);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_CustomerShips, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_CustomerShips);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<ShipHeadRow>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  ");
                            return _result;
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetOrderLine : " + ex.Message);
                return null;
            }
        }

        internal void MarkCustomerShipDeleted(ShipHeadRow shipHeadRow)
        {
            DLog.Log("GetCustomerShip for packNum :" + shipHeadRow.PackNum);


            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    var _Request = JsonConvert.SerializeObject(shipHeadRow);

                    DLog.Log("Calling Epicor api :" + string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum));
                    var _response = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum), "Patch", _Request);
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum));

                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<ShipHeadRow>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  ");

                        }

                    }
                }
                DLog.Log("Epicor api return no record");

            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetOrderLine : " + ex.Message);

            }
        }

        /// <summary>
        /// GetPartBin
        /// </summary>
        /// <returns></returns>
        //public List<PartBin> GetPartBin()
        //{
        //    DLog.Log("GetShipHead");
        //    apiResponse = new ApiResponse();
        //    try
        //    {
        //        DLog.Log("Calling Epicor api :" + Constant.EpicorApi_PartBin);
        //        var _response = apiResponse.GetApiResponse(Constant.EpicorApi_PartBin, "Get");
        //        if (!_response.success)
        //        {
        //            DLog.Log("Epicor api failed  " + Constant.EpicorApi_PartBin);
        //            return null;
        //        }

        //        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
        //        if (_data.ContainsKey("value"))
        //        {

        //            if (!String.IsNullOrEmpty(_data["value"].ToString()))
        //            {
        //                var _result = JsonConvert.DeserializeObject<List<PartBin>>(_data["value"].ToString());
        //                DLog.Log("Epicor api return records  " + _result.Count);
        //                return _result.ToList();
        //            }

        //        }

        //        DLog.Log("Epicor api return no record");
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("Exception in ReleaseOrder : " + ex.Message);
        //        return null;
        //    }
        //}

        public List<CustomerGroupModel> GetCustomerGroup()
        {

            DLog.Log("GetOrderShipDetail");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_GetCustomerGroups);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_GetCustomerGroups, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_GetCustomerGroups);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<List<CustomerGroupModel>>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  " + _result.Count);
                            return _result.ToList();
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in ReleaseOrder : " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// GetOrderShipDetail
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        //public List<ShipDtl> GetShipDetail()
        //{
        //    DLog.Log("GetOrderShipDetail");
        //    apiResponse = new ApiResponse();
        //    try
        //    {
        //        DLog.Log("Calling Epicor api :" + Constant.EpicorApi_ShipDetail);
        //        var _response = apiResponse.GetApiResponse(Constant.EpicorApi_ShipDetail, "Get");
        //        if (!_response.success)
        //        {
        //            DLog.Log("Epicor api failed  " + Constant.EpicorApi_ShipDetail);
        //            return null;
        //        }

        //        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
        //        if (_data.ContainsKey("value"))
        //        {

        //            if (!String.IsNullOrEmpty(_data["value"].ToString()))
        //            {
        //                var _result = JsonConvert.DeserializeObject<List<ShipDtl>>(_data["value"].ToString());
        //                DLog.Log("Epicor api return records  " + _result.Count);
        //                return _result.ToList();
        //            }

        //        }

        //        DLog.Log("Epicor api return no record");
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("Exception in ReleaseOrder : " + ex.Message);
        //        return null;
        //    }
        //}

        public List<ShipHeadModel> GetShipHead()
        {
            DLog.Log("GetShipHead");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_ShipHead);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_ShipHead, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_ShipHead);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<List<ShipHeadModel>>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  " + _result.Count);
                            return _result.ToList();
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in ReleaseOrder : " + ex.Message);
                return null;
            }
        }


        //Gobind
        public List<Customer> GetCustomers()
        {
            DLog.Log("GetShipHead");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_GetCustomers);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_GetCustomers, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_GetCustomers);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<List<Customer>>(_data["value"].ToString());
                            DLog.Log("Epicor api return records  " + _result.Count);
                            return _result.ToList();
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in ReleaseOrder : " + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shipToNum"></param>
        /// <returns></returns>
        public ShipToModel GetShipTos(string shipToNum)
        {
            DLog.Log("GetShipTos for shipToNum :" + shipToNum);

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    DLog.Log("Calling Epicor api :" + Constant.EpicorApi_ShipTos);
                    var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_ShipTos, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_ShipTos);
                        return null;
                    }

                    var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    if (_data.ContainsKey("value"))
                    {

                        if (!String.IsNullOrEmpty(_data["value"].ToString()))
                        {
                            var _result = JsonConvert.DeserializeObject<List<ShipToModel>>(_data["value"].ToString()).FirstOrDefault(f => f.ShipToNum.Equals(shipToNum));
                            DLog.Log("Epicor api return records  ");
                            return _result;
                        }

                    }
                }
                DLog.Log("Epicor api return no record");
                return null;
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetOrderLine : " + ex.Message);
                return null;
            }

        }


        /// <summary>
        /// GetShipVia
        /// </summary>
        /// <returns></returns>
        //public List<ShipVia> GetShipVia()
        //{
        //    DLog.Log("GetShipTos for ShipVia :");
        //    apiResponse = new ApiResponse();
        //    try
        //    {
        //        DLog.Log("Calling Epicor api :" + Constant.EpicorApi_ShipVias);
        //        var _response = apiResponse.GetApiResponse(Constant.EpicorApi_ShipVias, "Get");
        //        if (!_response.success)
        //        {
        //            DLog.Log("Epicor api failed  " + Constant.EpicorApi_ShipVias);
        //            return null;
        //        }

        //        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
        //        if (_data.ContainsKey("value"))
        //        {

        //            if (!String.IsNullOrEmpty(_data["value"].ToString()))
        //            {
        //                var _result = JsonConvert.DeserializeObject<List<ShipVia>>(_data["value"].ToString());//.FirstOrDefault(f => f.ShipToNum.Equals(shipToNum));
        //                DLog.Log("Epicor api return records  ");
        //                return _result;
        //            }

        //        }

        //        DLog.Log("Epicor api return no record");
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("Exception in GetOrderLine : " + ex.Message);
        //        return null;
        //    }

        //}



        /// <summary>
        /// GetOrderLine
        /// </summary>

        /// <returns></returns>



        /// <summary>
        /// GetWebOrder
        /// </summary>
        /// <returns></returns>
        public List<OrderHeadModel> GetOrderHead()
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

        internal List<OrderDetailModel> GetOrderLineItemByOrdernum(string company, int orderNum)
        {
            DLog.Log("Get OrderRelationByOrdernum for OrderNum :" + company);

            try
            {
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
                DLog.Log("Exception in OrderRelationByOrdernum : " + ex.Message);
                return null;
            }
        }

        internal void UpdateOrderLines(OrderHedRow orderHedRow, List<OrderDtlRow> rsEpicorLineItems)
        {
            DLog.Log("UpdateOrderRelease for OrderNum :" + orderHedRow.OrderNum);


            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    var _Request = JsonConvert.SerializeObject(rsEpicorLineItems);

                    //DLog.Log("Calling Epicor api :" + string.Format(Constant.EpicorApi_CustomerShips, orderHedRow.Company, shipHeadRow.PackNum));
                    //var _response = apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum), "Patch", _Request);
                    //if (!_response.success)
                    //{
                    //    DLog.Log("Epicor api failed  " + string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum));

                    //}

                    //var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    //if (_data.ContainsKey("value"))
                    //{

                    //    if (!String.IsNullOrEmpty(_data["value"].ToString()))
                    //    {
                    //        var _result = JsonConvert.DeserializeObject<ShipHeadRow>(_data["value"].ToString());
                    //        DLog.Log("Epicor api return records  ");

                    //    }

                    //}
                }
                DLog.Log("Epicor api return no record");

            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetOrderLine : " + ex.Message);

            }
        }

        //12/04/2019
        //public OrderHedRow GetOrderByOrdernum(string Company, int OrderNum)
        //{
        //    DLog.Log("GetWebOrder");
        //    apiResponse = new ApiResponse();
        //    try
        //    {
        //        string uri= string.Format(Constant.EpicorApi_SalesOrderByOrdernum, Company, OrderNum);
        //        DLog.Log("Calling Epicor api :" + uri);
        //        var _response = apiResponse.GetApiResponse(uri, "Get");
        //        if (!_response.success)
        //        {
        //            DLog.Log("Epicor api failed  " + Constant.EpicorApi_SalesOrder);
        //            return null;
        //        }
        //        else
        //        {
        //            var _result = string.Concat("{", _response.Response.Substring(_response.Response.IndexOf(",") + 1));

        //            //JsonConvert.DeserializeObject<Dictionary<string, string>>(_response.Response);
        //            DLog.Log(string.Format("Epicor api return {0} record",_result.Count()));


        //            //return JsonConvert.DeserializeObject<SalesOrderDataSet.OrderHedDataTable>("["+_result+"]").Rows[0] as OrderHedRow;
        //            return JsonConvert.DeserializeObject<SalesOrderDataSet.OrderHedDataTable>("[" + _result + "]").Rows[0] as OrderHedRow;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("Exception in GetWebOrder : " + ex.Message);
        //        return null;
        //    }
        //}
        public OrderHedRow GetOrderByOrdernum(string Company, int OrderNum)
        {
            DLog.Log("GetWebOrder");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    string uri = string.Format(Constant.EpicorApi_SalesOrderByOrdernum, Company, OrderNum);
                    DLog.Log("Calling Epicor api :" + uri);
                    var _response = _apiResponse.GetApiResponse(uri, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_SalesOrder);
                        return null;
                    }
                    else
                    {
                        var _result = string.Concat("{", _response.Response.Substring(_response.Response.IndexOf(",") + 1));

                        //JsonConvert.DeserializeObject<Dictionary<string, string>>(_response.Response);
                        DLog.Log(string.Format("Epicor api return {0} record", _result.Count()));


                        //return JsonConvert.DeserializeObject<SalesOrderDataSet.OrderHedDataTable>("["+_result+"]").Rows[0] as OrderHedRow;
                        return JsonConvert.DeserializeObject<SalesOrderDataSet.OrderHedDataTable>("[" + _result + "]").Rows[0] as OrderHedRow;
                    }
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetWebOrder : " + ex.Message);
                return null;
            }
        }
        public List<OrderDetailModel> GetOrderDtlOrdernum(string Company, int OrderNum, int Linenum)
        {
            DLog.Log("GetOrderDtl Company Ordernum Linenum");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    string uri = string.Format(Constant.EpicorApi_OrderDtlByOrdernum, Company, OrderNum, Linenum);
                    DLog.Log("Calling Epicor api :" + uri);
                    var _response = _apiResponse.GetApiResponse(uri, "Get");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_OrderDtlByOrdernum);
                        return null;
                    }
                    else
                    {
                        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                        if (_data.ContainsKey("value"))
                        {

                            if (!String.IsNullOrEmpty(_data["value"].ToString()))
                            {
                                var _result = JsonConvert.DeserializeObject<List<OrderDetailModel>>(_data["value"].ToString());
                                DLog.Log("Epicor api return records  " + _result.Count);
                                return _result.ToList();
                            }

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

        internal void UpdateOrderRelease(OrderHedRow orderHedRow, List<OrderRelRow> rsEpicorReleaseItems)
        {
            DLog.Log("UpdateOrderRelease for OrderNum :" + orderHedRow.OrderNum);


            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    var _Request = JsonConvert.SerializeObject(rsEpicorReleaseItems);

                    //DLog.Log("Calling Epicor api :" + string.Format(Constant.EpicorApi_CustomerShips, orderHedRow.Company, shipHeadRow.PackNum));
                    var _response = _apiResponse.GetApiResponse(string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum), "Patch", _Request);
                    //if (!_response.success)
                    //{
                    //    DLog.Log("Epicor api failed  " + string.Format(Constant.EpicorApi_CustomerShips, shipHeadRow.Company, shipHeadRow.PackNum));

                    //}

                    //var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                    //if (_data.ContainsKey("value"))
                    //{

                    //    if (!String.IsNullOrEmpty(_data["value"].ToString()))
                    //    {
                    //        var _result = JsonConvert.DeserializeObject<ShipHeadRow>(_data["value"].ToString());
                    //        DLog.Log("Epicor api return records  ");

                    //    }

                    //}
                }
                DLog.Log("Epicor api return no record");

            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetOrderLine : " + ex.Message);

            }
        }

        public List<OrderRelRow> GetOrderRelationByOrdernum(string Company, int OrderNum)
        {
            DLog.Log("Get OrderRelationByOrdernum for OrderNum :" + OrderNum);

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    string uri = string.Format(Constant.EpicorApi_ReleaseOrders, Company, OrderNum);
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

                                var _result = JsonConvert.DeserializeObject<OrderRelDataTable>(_data["value"].ToString());

                                DLog.Log("Epicor api return records  " + _result.Rows.Count);
                                List<OrderRelRow> OrderRelRows = new List<OrderRelRow>();
                                foreach (var row in _result.Rows)
                                {
                                    OrderRelRows.Add(row as OrderRelRow);
                                }
                                return OrderRelRows;
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
                DLog.Log("Exception in OrderRelationByOrdernum : " + ex.Message);
                return null;
            }
        }
        public string PatchtOrderByOrdernum(OrderHedRow data, OrderHeadModel Input, string datainputs)
        {
            DLog.Log("PatchWebOrder");

            try
            {
                using (_apiResponse = new ApiResponse())
                {
                    //var data json.par
                    //string uri = string.Format(Constant.EpicorApi_PatchSalesOrderByOrdernum, data.Company, data.OrderNum, JsonConvert.SerializeObject(Input));
                    //string uri = string.Format(Constant.EpicorApi_PatchSalesOrderByOrdernum, data.Company, data.OrderNum, Input);
                    //string uri= string.Format(Constant.EpicorApi_PatchSalesOrderByOrdernum, data.Company, data.OrderNum);

                    string localdata = "";
                    string uri = string.Format(Constant.EpicorApi_PatchSalesOrderByOrdernum, data.Company, data.OrderNum, "");

                    DLog.Log("Calling Epicor api :" + uri);

                    var _response = _apiResponse.GetApiResponse(uri, "Patch");
                    if (!_response.success)
                    {
                        DLog.Log("Epicor api failed  " + Constant.EpicorApi_PatchSalesOrderByOrdernum);
                        return null;
                    }
                    else
                    {

                        //var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
                        var _data = JsonConvert.DeserializeObject<Dictionary<string, string>>(_response.Response);
                        return _data.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Exception in GetWebOrder : " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// GetVendorBank
        /// </summary>
        /// <param name="sAcctNumb"></param>
        /// <returns></returns>
        //public List<VendBank> GetVendorBank(string sAcctNumb)
        //{
        //    DLog.Log("GetVendorBank");
        //    apiResponse = new ApiResponse();
        //    try
        //    {
        //        DLog.Log("Calling Epicor api :" + Constant.EpicorApi_VendBankSearchList);
        //        var _response = apiResponse.GetApiResponse(Constant.EpicorApi_VendBankSearchList, "Get");
        //        if (!_response.success)
        //        {
        //            DLog.Log("Epicor api failed  " + Constant.EpicorApi_VendBankSearchList);
        //            return null;
        //        }

        //        var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
        //        if (_data.ContainsKey("value"))
        //        {

        //            if (!String.IsNullOrEmpty(_data["value"].ToString()))
        //            {
        //                var _result = JsonConvert.DeserializeObject<List<VendBank>>(_data["value"].ToString());
        //                DLog.Log("Epicor api return records  " + _result.Count);
        //                return _result.Where(f => string.IsNullOrEmpty(sAcctNumb) || f.BankAcctNumber.Equals(sAcctNumb)).ToList(); ;
        //            }

        //        }

        //        DLog.Log("Epicor api return no record");
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("Exception in GetVendorBank : " + ex.Message);
        //        return null;
        //    }

        //}

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
                _apiResponse = null;
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EpicorBusinessApi() {
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



    }
}
