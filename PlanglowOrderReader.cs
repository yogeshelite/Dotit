using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

using DotCommon;
using DotitBllDal;


namespace EpicorDaily
{
    class PlanglowOrderReader
    {

        public static void GetPlanglowOrders()
        {
            List<DataStructures.SalesOrder> listSOs = new List<DataStructures.SalesOrder>();

            String url = @"https://www.planglow-usa.com/net/WebService.aspx?Login=Rachael.Sawtell@Planglow.com&EncryptedPassword=332B6F7BABE598CE9EE6C79A5A335712F13FBAD27FE0B96B221344FA0E55E215&EDI_Name=Generic\Orders&SELECT_Columns=*";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                myRequest.Method = "GET";
                myRequest.ContentType = "text/xml;encoding='utf-8'";

                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                XmlDocument xmlDoc = new XmlDocument();
                XmlTextReader reader = new XmlTextReader(myResponse.GetResponseStream());
                xmlDoc.Load(reader);
                String xml = xmlDoc.InnerXml;
                xmldata volResponse = (xmldata)DSerial.Deserialize(xml, typeof(xmldata));

                foreach (VolOrder vo in volResponse.Orders)
                {
                    try
                    {
                        


                        DataStructures.SalesOrder so = new DataStructures.SalesOrder();

                        so.customerId = vo.CustomerID;
                        so.customerNumber = CustomerE10.GetCustNumById(vo.CustomerID);
                        so.isCreditCardOrder = true; //TODO - Figure out if CC order or now
                        so.isOrderHeld = false;
                        so.isShipOrderComplete = true;
                        so.miscFreightCharge = vo.TotalShippingCost;
                        so.needByDate = DateTime.Now.AddDays(4);
                        so.orderCast = DataStructures.OrderCast.LinesOnly;
                        so.orderType = "EDI";
                        so.ourRate = 0.0m; //TODO - Calculate shipping cost based on our number
                                           //so.publicRate
                        so.poNumber = "Planglow - " + vo.OrderID;
                        so.shipToOneTime = true;
                        so.shipVia = "UPC"; //TODO - Figure out how to translate methods of shipping


                        foreach (VolOrderDetail vod in vo.OrderDetails)
                        {
                            DataStructures.SalesOrderLineItem soli = new DataStructures.SalesOrderLineItem();

                            soli.needByDate = so.needByDate;
                            soli.submittedPartNumber = vod.ProductID;
                            soli.submittedQuantity = Convert.ToInt32(vod.Quantity);
                            soli.submittedUnitPrice = Convert.ToDecimal(vod.ProductPrice);

                            so.listLineItems.Add(soli);
                        }

                    }
                    catch (Exception ex)
                    {
                        DLog.LogErr(ex, "", true);
                    }
                }

            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
            }

        }


        public static void ProcessPlanglowOrders(List<DataStructures.SalesOrder> listSOs)
        {



        }


        public class xmldata
        {
            [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public VolOrder[] Orders { get; set; }
            public xmldata()
            {
                Orders = new VolOrder[1];
            }
        }


        public class VolOrder
        {
            public String OrderID { get; set; }
            public String AddressValidated { get; set; }
            public String AuthHash { get; set; }
            public String AVS { get; set; }
            public String BillingAddress1 { get; set; }
            public String BillingAddress2 { get; set; }
            public String BillingCity { get; set; }
            public String BillingCompanyName { get; set; }
            public String BillingCountry { get; set; }
            public String BillingFaxNumber { get; set; }
            public String BillingFirstName { get; set; }
            public String BillingLastName { get; set; }
            public String BillingPhoneNumber { get; set; }
            public String BillingPostalCode { get; set; }
            public String BillingState { get; set; }
            public String CardHoldersName { get; set; }
            public String CC_Last4 { get; set; }
            public String CreditCardAuthorizationDate { get; set; }
            public String CreditCardAuthorizationNumber { get; set; }
            public String CreditCardTransactionID { get; set; }
            public String Customer_IPAddress { get; set; }
            public String CustomerID { get; set; }
            public String CVV2_Response { get; set; }
            public String GiftWrapNote { get; set; }
            public String InitiallyShippedDate { get; set; }
            public String IsAGift { get; set; }
            public String IsGTSOrder { get; set; }
            public String LastModBy { get; set; }
            public String LastModified { get; set; }
            public String Locked { get; set; }
            public String Order_Comments { get; set; }
            public String Order_Entry_System { get; set; }
            public String OrderDate { get; set; }
            public String OrderDateUtc { get; set; }
            public String OrderNotes { get; set; }
            public String OrderStatus { get; set; }
            public Decimal PaymentAmount { get; set; }
            public String PaymentMethodID { get; set; }
            public String PCIaaS_CardId { get; set; }
            public String PCIaaS_MaskedCardRef { get; set; }
            public String PONum { get; set; }
            public String Processed_AutoEvents { get; set; }
            public String SalesRep_CustomerID { get; set; }
            public Decimal SalesTax1 { get; set; }
            public Decimal SalesTax2 { get; set; }
            public Decimal SalesTax3 { get; set; }
            public Decimal SalesTaxRate { get; set; }
            public Decimal SalesTaxRate1 { get; set; }
            public Decimal SalesTaxRate2 { get; set; }
            public Decimal SalesTaxRate3 { get; set; }
            public String ShipAddress1 { get; set; }
            public String ShipAddress2 { get; set; }
            public String ShipCity { get; set; }
            public String ShipCompanyName { get; set; }
            public String ShipCountry { get; set; }
            public String ShipDate { get; set; }
            public String ShipFaxNumber { get; set; }
            public String ShipFirstName { get; set; }
            public String ShipLastName { get; set; }
            public String Shipped { get; set; }
            public String ShipPhoneNumber { get; set; }
            public String Shipping_Locked { get; set; }
            public String ShippingMethodID { get; set; }
            public String ShipPostalCode { get; set; }
            public String ShipResidential { get; set; }
            public String ShipState { get; set; }
            public String sOrderID { get; set; }
            public String Stock_Priority { get; set; }
            public String Tax1_IgnoreNoTaxRules { get; set; }
            public String Tax1_Title { get; set; }
            public String Tax2_IgnoreNoTaxRules { get; set; }
            public String Tax2_Title { get; set; }
            public String Tax3_IgnoreNoTaxRules { get; set; }
            public String Tax3_Title { get; set; }
            public Decimal Total_Payment_Authorized { get; set; }
            public Decimal Total_Payment_Received { get; set; }
            public Decimal TotalShippingCost { get; set; }
            public String VendorID { get; set; }
            [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public VolOrderDetail[] OrderDetails { get; set; }

            public VolOrder()
            {
                OrderDetails = new VolOrderDetail[1];
            }
        }


        public class VolOrderDetail
        {
            public String OrderDetailID { get; set; }
            public String AutoDropShip { get; set; }
            public String FreeShippingItem { get; set; }
            public String GiftTrakNumber { get; set; }
            public String GiftWrap { get; set; }
            public String GiftWrapCost { get; set; }
            public String GiftWrapNote { get; set; }
            public String IsKitID { get; set; }
            public String KitID { get; set; }
            public String LastModified { get; set; }
            public String Locked { get; set; }
            public String OnOrder_Qty { get; set; }
            public String OptionIDs { get; set; }
            public String Options { get; set; }
            public String OrderID { get; set; }
            public String ProductCode { get; set; }
            public String ProductID { get; set; }
            public String ProductName { get; set; }
            public String ProductNote { get; set; }
            public String ProductPrice { get; set; }
            public String ProductWeight { get; set; }
            public String QtyOnBackOrder { get; set; }
            public String QtyOnHold { get; set; }
            public String QtyOnPackingSlip { get; set; }
            public String QtyShipped { get; set; }
            public String Quantity { get; set; }
            public String ShipDate { get; set; }
            public String TaxableProduct { get; set; }
            public String TotalPrice { get; set; }
            public String Warehouses { get; set; }
        }



    }
}
