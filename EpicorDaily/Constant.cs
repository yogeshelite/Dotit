using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily
{
   public static class Constant
    {
       
        
        public const string EpicorApi_SalesOrder=  "/Erp.BO.SalesOrderSvc/SalesOrders";
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
        public const string EpicorApi_ShipDetail= "/Erp.BO.ShipDtlSearchSvc/List";
        public const string EpicorApi_ShipTos= "/Erp.BO.ShipToSvc/List";
        public const string EpicorApi_ShipHead = "/Erp.BO.CustShipSvc/List";

        public const string EpicorApi_GetCustomers = "/Erp.BO.CustomerSvcGET/Customers";

        public const string EpicorApi_GetCustomerGroups = "/Erp.BO.CustGrupSvc/List";
        public const string EpicorApi_CustomerShips = "/Erp.BO.CustShipSvc/CustShips({0},{1})";



        public const string EpicorApi_ShipVias = "/Erp.BO.ShipViaSvc/ShipVias";






    }
}
