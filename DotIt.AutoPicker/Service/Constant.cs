using System;
namespace DotIt.AutoPicker.Models
{
    public static class Constant
    {
        public const string EpicorApi_AuthPicker = "Erp.BO.UserFileSvc/UserFiles({0})"; // 0: docuserid 
        public const string EpicorApi_SalesOrder = "/Erp.BO.SalesOrderSvc/SalesOrders";
        public const string EpicorApi_SalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1})";
        public const string EpicorApi_SalesOrderRelationByOrdernum = "Erp.BO.OrderRelSearchSvc/OrderRelSearches({0})";
        public const string EpicorApi_PatchSalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1},{2})";
        //public const string EpicorApi_PatchSalesOrderByOrdernum = "Erp.BO.SalesOrderSvc/SalesOrders({0},{1})";
        public const string EpicorApi_SalesOrderList = "/Erp.BO.SalesOrderSvc/List";
        public const string EpicorApi_VendBankSearchList = "/Erp.BO.VendBankSearchSvc/List";
        public const string EpicorApi_OrderLineItems = "rp.BO.OrderDtlSearchSvc/OrderDtlSearches?$filter=Company eq '{0}' and OrderNum eq {1}";
        public const string EpicorApi_ReleaseOrders = "/Erp.BO.OrderRelSearchSvc/List?$filter=Company eq '{0}' and OrderNum eq {1}";
        //public const string EpicorApi_ReleaseOrders = "/Erp.BO.OrderRelSearchSvc/List?$filter='{0}'and{1}";
        public const string EpicorApi_PartBin = "/Erp.BO.PartBinSearchSvc";
        public const string EpicorApi_ShipDetail = "/Erp.BO.ShipDtlSearchSvc/List";
        public const string EpicorApi_ShipTos = "/Erp.BO.ShipToSvc/List";
        public const string EpicorApi_ShipHead = "/Erp.BO.CustShipSvc/List";
        public const string EpicorApi_GetCustomers = "/Erp.BO.CustomerSvcGET/Customers";
        public const string EpicorApi_GetCustomerGroups = "/Erp.BO.CustGrupSvc/List";
        public const string EpicorApi_ShipVias = "/Erp.BO.ShipViaSvc/ShipVias";
        public const int NumberOfOrdersToShow = 50;
        public static string Encode(int id)
        {
            return Convert.ToBase64String((System.Text.Encoding.UTF8.GetBytes(id.ToString())));
        }
        public const string EpicorApi_OrderDetails = "/Erp.BO.SalesOrderSvc/OrderDtls";
        public const string EpicorApi_OrderLine = "/Erp.BO.SalesOrderSvc/OrderDtls({0},{1},{2})"; // 0:Company;1:OrderNum;2:Linenum 
        public const string LogFilePath = @"\log.csv";
        public const string OrderInProcessing = @"\OrderInProcessing.csv";
        public const string OrderStatus = @"\OrderStatus.csv";
        public const string PickFilePath = @"\PickedOrders.csv";
        public const string QuarantineFilePath = @"\Quarantine.csv";
        public const string PickersFilePath = @"\Pickers.csv";
        public const string AdminCredentialsPath = @"\Admin Credentials.csv";
        public const string LoggedInUserPath = @"\LoggedInUsers";
        public const string UserCookie = "UserCookie";

    }
}

