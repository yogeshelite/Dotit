using System;
namespace DotIt.AutoPickerApi.Service
{
    public static class Constant
    {
        public const int NumberOfOrdersToShow = 50;
        public static string Encode(string id)
        {
            return Convert.ToBase64String((System.Text.Encoding.UTF8.GetBytes(id)));
        }
        public static class EpicorApi
        {
            public const string AuthPicker = "Erp.BO.UserFileSvc/UserFiles({0})"; // 0: docuserid 
            public const string SalesOrder = "/Erp.BO.SalesOrderSvc/SalesOrders";
            public const string SalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1})";
            public const string SalesOrderRelationByOrdernum = "Erp.BO.OrderRelSearchSvc/OrderRelSearches({0})";
            public const string PatchSalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1},{2})";
            //public const string PatchSalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1})";
            public const string SalesOrderList = "/Erp.BO.SalesOrderSvc/List";
            public const string SalesOrderFilter = "Erp.BO.SalesOrderSvc/SalesOrders?$filter=(OpenOrder%20eq%20{0}%20and%20RequestDate%20gt%20DateTime'{1}')&$expand=OrderDtls";
            public const string VendBankSearchList = "/Erp.BO.VendBankSearchSvc/List";
            public const string OrderLineItems = "rp.BO.OrderDtlSearchSvc/OrderDtlSearches?$filter=Company eq '{0}' and OrderNum eq {1}";
            public const string ReleaseOrders = "/Erp.BO.OrderRelSearchSvc/List?$filter=Company eq '{0}' and OrderNum eq {1}";
            //public const string ReleaseOrders = "/Erp.BO.OrderRelSearchSvc/List?$filter='{0}'and{1}";
            public const string PartBin = "/Erp.BO.PartBinSearchSvc";
            public const string Parts = "/Erp.BO.PartSvc/Parts";
            public const string PartBinSearch = "/Erp.BO.PartBinSearchSvc/GetPartBinSearch";//Method Post{"PageSize": 0,"AbsolutePage": 0,"whereClause": "PartNum='DSY290'"}
            public const string ShipDetail = "/Erp.BO.ShipDtlSearchSvc/List";
            public const string ShipTos = "/Erp.BO.ShipToSvc/List";
            public const string ShipHead = "/Erp.BO.CustShipSvc/List";
            public const string GetCustomers = "/Erp.BO.CustomerSvcGET/Customers";
            public const string GetCustomerGroups = "/Erp.BO.CustGrupSvc/List";
            public const string ShipVias = "/Erp.BO.ShipViaSvc/ShipVias";
            
            public const string OrderDetails = "/Erp.BO.SalesOrderSvc/OrderDtls";
            public const string OrderDetailsFilter = "/Erp.BO.SalesOrderSvc/OrderDtls?$filter=OrderNum%20eq%201011";
            public const string OrderLine = "/Erp.BO.SalesOrderSvc/OrderDtls({0},{1},{2})"; // 0:Company;1:OrderNum;2:Linenum 


            public const string LogFilePath = @"\log.csv";

        

            //public const string PatchSalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1},{2})";
            //public const string ReleaseOrders = "/Erp.BO.OrderRelSearchSvc/List?$filter=Company eq '{0}' and OrderNum eq {1}";
            public const string PartBinSearchSvc = "/Erp.BO.PartBinSearchSvc/GetFullBinSearch";
            public const string PartBinSearchSvc2 = "/Erp.BO.PartBinSearchSvc/GetFullBinSearch?$filter=partNum eq '{0}' and whseCode eq {1}";
            public const string PartBinSearchSvc3 = "/Erp.BO.PartBinSearchSvc/GetFullBinSearch?$input=partNum eq '{0}' and whseCode eq {1}";

            public const string Images = "/Erp.BO.ImageSvc/Images({0},{1})"; //(DIRF,10503BC_big)
        }
        public static class Session
        {
            public const string LoggedInUserPath = @"\LoggedInUsers";
            public const string UserCookie = "UserCookie";
        }
        public static class Message
        {
            public const string Success = "{0} {1} successfully";
            public const string Failed = "{0} {1}";
        }
    }
}

