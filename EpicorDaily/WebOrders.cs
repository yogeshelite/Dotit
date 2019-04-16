using System;
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DotCommon;
using DotitBllDal;

using Ice.Core;
using Ice.Lib.Framework;
using Erp.BO;
using Erp.Proxy.BO;
using static Erp.BO.SalesOrderDataSet;

namespace EpicorDaily
{
    public static class WebOrders
    {
        public class RTACO
        {
            public String rtacoCustId { get; set; }
            public RTACO() { }
            public RTACO(String l)
            {
                this.rtacoCustId = l;
            }
        }

        #region//20190404- Amit : Property declare to call Epicor Api Caller 
        public static EpicorBusinessApi _EpicorBusinessApi { get; set; }
        //public static object Notifications { get; private set; }

        #endregion
        public static void OrderAdjustments(Session session)
        {
            try
            {
                DLog.StartModule();

                EpicorE10DataContext db = new EpicorE10DataContext(DLog.CS);
                #region//20190404- Amit : Code change to orderNum  and company  
                //IQueryable<Int32> rsOrders = from oh in db.OrderHeds
                //                             join ohud in db.OrderHed_UDs on oh.SysRowID equals ohud.ForeignSysRowID
                //                             where oh.WebOrder && ohud.orderType_c == ""
                //                             select oh.OrderNum;

                var rsOrders = from oh in db.OrderHeds
                               join ohud in db.OrderHed_UDs on oh.SysRowID equals ohud.ForeignSysRowID
                               where oh.WebOrder && ohud.orderType_c == ""
                               select new { OrderNum = oh.OrderNum, Company = oh.Company };
                #endregion

                if (rsOrders.Count() <= 0)
                {
                    DLog.Log("Nothing to do at this time, bailing from OrderAdjustments");
                    return;
                }

                DLog.Log("There are " + rsOrders.Count().ToString() + " orders without OrderType");

                List<OrderAPIResponse> listOrdAPIs = new List<OrderAPIResponse>();
                OrderAPIResponse ordAPI = new OrderAPIResponse();

                #region//20190404- Amit : Code change variable name  
                //foreach (int32 ordernum in rsOrders)
                //SalesOrderDataSet salesOrderDS;
                SalesOrderDataSet.OrderHedRow orderHedRow;
                DotItShipping dis;
                foreach (var order in rsOrders)
                #endregion
                {
                    DLog.Log("Looping through with order number: " + order.ToString());

                    #region//20190404- Amit : Stop mail notification to Jarod on testing 
                    if (!DLog.isTest) NotifyJarod(order.OrderNum);
                    #endregion
                    OrderResponse[] ordRspArray = GetMagentoLineItemDetails(order.OrderNum);

                    if (ordRspArray == null) continue;

                    #region//20190404- Amit : Property declare to call Epicor Api Caller 
                    //using (var salesOrderBO = WCFServiceSupport.CreateImpl<SalesOrderImpl>(session, SalesOrderImpl.UriPath))
                    //{

                    #endregion
                    Boolean isContinue = new Boolean();
                    String responseMessage = string.Empty;
                    String creditShipAction;
                    String displayMessage;
                    String compliantMessage;
                    String responseMsgOrdRel;
                    String cAgingMessage;
                    Boolean lCheckForOrderChangedMsg = false;
                    Boolean lcheckForResponse = false;

                    #region//20190404- Amit : Property declare to call Epicor Api Caller 
                    //12/01/2019
                    //SalesOrderDataSet salesOrderDS = salesOrderBO.GetByID(orderNum);
                    //SalesOrderDataSet.OrderHedRow orderHedRow orderHedRow = salesOrderDS.OrderHed[0];

                    using (_EpicorBusinessApi = new EpicorBusinessApi())
                    {
                        orderHedRow = _EpicorBusinessApi.GetOrderByOrdernum(order.Company, order.OrderNum);
                        #endregion

                        DLog.Log("Have order number: " + orderHedRow.OrderNum.ToString());

                        #region Rtaco Temp Fix - Part 1
                        //  Part of a temporary fix mid July 2017.  Intent was to force ship complete for large shipment of a part that was delayed
                        //if (BodilyFluidPart(orderNum)) orderHedRow.ShipOrderComplete = true;

                        ////  Special customization for RTaco orders - this should be temporary until we get the Amasty extension in Magento working properly
                        ////  If an order is greater than $250 in product, we are to the following part to the order - RTaco customer group only
                        //Boolean isRTacoPromo = false;
                        //try
                        //{
                        //    if (File.Exists("rtacospecial.xml"))
                        //    {
                        //        DLog.Log("rtacospecial.xml exits");

                        //        String xml = File.ReadAllText("rtacospecial.xml");

                        //        List<RTACO> listRTaco = (List<RTACO>)DSerial.Deserialize(xml, typeof(List<RTACO>));

                        //        if (listRTaco.Any(o => o.rtacoCustId == orderHedRow.CustNum.ToString()))
                        //        {
                        //            DLog.Log("We have an legit RTACO account: " + orderHedRow.CustNum.ToString());

                        //            var rsOrderSize = (from oh in db.OrderHeds
                        //                               join c in db.Customers on oh.CustNum equals c.CustNum
                        //                               where oh.OrderNum == orderNum && c.GroupCode.ToUpper() == "RTAC"
                        //                               select oh.CCAmount).Single();
                        //            DLog.Log("Order: " + orderNum.ToString() + " order size: " + rsOrderSize.ToString());
                        //            if (rsOrderSize >= 250.0m) isRTacoPromo = true;
                        //        }
                        //    }
                        //}
                        //catch (Exception ex)
                        //{
                        //    DLog.Log("RTacoPromo: " + ex.Message, DLog.LogLevel.Error);
                        //}
                        #endregion

                        orderHedRow["orderType_c"] = "Online";
                        orderHedRow.InvoiceComment = "";
                        dis = new DotItShipping();
                        orderHedRow.RequestDate = dis.NextShippingDate();
                        orderHedRow.PayFlag = "SHIP";
                        orderHedRow.FOB = "Delivered";
                        orderHedRow.ApplyChrg = false;
                        orderHedRow.ChrgAmount = 0.0m;
                        orderHedRow.OrderComment += Environment.NewLine + "Email: " + ordRspArray[0].customerEmail + " <EmailEnd>";
                        if (orderHedRow.ShipViaCode == "FREE") orderHedRow.ShipViaCode = "UPC";         //  Web orders with free shipping need to go UPS Ground

                        //  Subscription based products, like Yext, do not need shipping.  If the order is only subscription based products, 
                        //  change the ship to "SUB" for subscription/download. Also note, code below will change ShipVia to orderHedRow.ShipVia
                        //Boolean isSubscriptionOnly = DetermineOrderIsSubscription(orderHedRow.OrderNum);
                        //if (isSubscriptionOnly)
                        //{
                        //    orderHedRow.ShipViaCode = "SUB";
                        //}


                        if (CheckForDaySpenser(order.OrderNum)) orderHedRow.ReadyToCalc = false;

                        #region//20190404- Amit : comment update call
                        //salesOrderBO.MasterUpdate(lCheckForOrderChangedMsg, lcheckForResponse, "OrderHed", orderHedRow.CustNum, orderHedRow.OrderNum, false,
                        //        out isContinue, out responseMessage, out creditShipAction, out displayMessage, out compliantMessage, out responseMsgOrdRel,
                        //        out cAgingMessage, salesOrderDS);

                        //Hare used epicor api for salesOrderBO.MasterUpdate for later...........................................................................

                        #endregion

                        DLog.Log("Master Update complete " + responseMessage);
                        #region//20190404- Amit :comment for DLog.Log( salesOrderDS)
                        //DLog.Log("Releases & Lines: " + salesOrderDS.OrderRel.Count.ToString() + " & " + salesOrderDS.OrderDtl.Count.ToString());

                        #endregion

                        #region Rtaco Temp Fix - Part 2
                        //Continuation of RTaco Promo
                        //if (isRTacoPromo)
                        //{
                        //    try
                        //    {
                        //        Guid sysRowId = new Guid();
                        //        String partNumber = "RTCO-SWAG-PK";
                        //        String uomCode = "PK";
                        //        String rowType = "";
                        //        String deleteComponentsMessage = "";
                        //        String questionString = "";
                        //        String warningMessage = "";
                        //        String configPartMessage = "";
                        //        String subPartMessage = "";
                        //        String explodeBOMerrMessage = "";
                        //        String messageType = "";
                        //        String pcMessage = "";
                        //        String pcNeqQtyAction = "";
                        //        String OpWarningMsg = "";
                        //        String cSellingQuantityChangedMsgText = "";

                        //        Boolean isSubstitutePartExist = new Boolean();
                        //        Boolean isPhantom = new Boolean();
                        //        Boolean isSalesKitView = new Boolean();
                        //        Boolean removeKitComponents = new Boolean();
                        //        Boolean suppressUserPrompts = new Boolean();
                        //        Boolean getPartXRefInfo = new Boolean();
                        //        Boolean checkPartRevisionChange = new Boolean();
                        //        Boolean checkChangeKitParent = new Boolean();
                        //        Boolean isMultipleMatch = new Boolean();
                        //        Boolean isPromptToExplodeBOM = new Boolean();
                        //        Boolean isMultiSubsAvail = new Boolean();
                        //        Boolean isRunOutQtyAvail = new Boolean();


                        //        salesOrderBO.GetNewOrderDtl(salesOrderDS, orderHedRow.OrderNum);
                        //        SalesOrderDataSet.OrderDtlRow orderDtlRow = salesOrderDS.OrderDtl[salesOrderDS.OrderDtl.Count - 1];
                        //        salesOrderBO.ChangePartNumMaster(ref partNumber, ref isSubstitutePartExist, ref isPhantom, ref uomCode, sysRowId, rowType, isSalesKitView, removeKitComponents,
                        //            suppressUserPrompts, getPartXRefInfo, checkPartRevisionChange, checkChangeKitParent, out deleteComponentsMessage, out questionString,
                        //            out warningMessage, out isMultipleMatch, out isPromptToExplodeBOM, out configPartMessage, out subPartMessage, out explodeBOMerrMessage, out messageType,
                        //            out isMultiSubsAvail, out isRunOutQtyAvail, salesOrderDS);
                        //        salesOrderBO.ChangeSellingQtyMaster(salesOrderDS, 1, false, false, true, true, true, true,
                        //            "RTCO-SWAG-PK", "", "", "", "PK", 1, out pcMessage, out pcNeqQtyAction, out OpWarningMsg, out cSellingQuantityChangedMsgText);

                        //        salesOrderBO.MasterUpdate(true, true, "OrderDtl", orderHedRow.CustNum, orderHedRow.OrderNum, false, out isContinue, out responseMessage, out creditShipAction,
                        //            out displayMessage, out compliantMessage, out responseMsgOrdRel, salesOrderDS);

                        //        DLog.Log("Rtacopromo end of adding line item");

                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        DLog.Log("RTacoPromo adding line item: " + ex.Message, DLog.LogLevel.Error);
                        //    }
                        //}
                        #endregion


                        List<OrderRel> rsReleaseItems = (from orr in db.OrderRels where orr.OrderNum == order.OrderNum select orr).ToList<OrderRel>();
                        ReleaseOrder(orderHedRow,rsReleaseItems);
                        isContinue = true;
                        #region//20190404- Amit : comment update call

                        //salesOrderBO.MasterUpdate(true, true, "OrderRel", orderHedRow.CustNum, orderHedRow.OrderNum, false, out isContinue, out responseMessage, out creditShipAction,
                        //                    out displayMessage, out compliantMessage, out responseMsgOrdRel, out cAgingMessage, salesOrderDS);

                        //Hare used epicor api for salesOrderBO.MasterUpdate for later...........................................................................

                        #endregion


                        DLog.Log("Release Item Update complete " + responseMessage);


                        Thread.Sleep(2000);  //  Have to sleep to allow final update of lines.

                        #region//20190404- Amit : comment for  DLog.Log ereeor 
                        // DLog.Log("There are " + salesOrderDS.OrderDtl.Count.ToString() + " from salesOrderDS.OrderDtl");
                        #endregion

                        #region//20190404- Amit : Refactor code for OrderLine Process 
                        ProcessEpicorOrderLine(orderHedRow, ordRspArray);
                        #endregion

                        DLog.Log("Line Item Update complete " + responseMessage);



                        isContinue = true;
                        #region//20190404- Amit :  Epicor Api Cal for  salesOrderBO.MasterUpdate 
                        //salesOrderBO.MasterUpdate(true, true, "OrderDtl", orderHedRow.CustNum, orderHedRow.OrderNum, false, out isContinue, out responseMessage, out creditShipAction,
                        //                out displayMessage, out compliantMessage, out responseMsgOrdRel, out cAgingMessage, salesOrderDS);

                        //DLog.Log("responseMessage: " + responseMessage);
                        //DLog.Log("displayMessage: " + displayMessage);
                        //DLog.Log("compliantMessage: " + compliantMessage);
                        //DLog.Log("creditShipAction: " + creditShipAction);
                        #endregion

                        #region//20190404- Amit : Property declare to call Epicor Api Caller 

                        //NotifyUserIfOnCreditHold(orderHedRow.OrderNum);                    
                        //}
                        #endregion

                    }
                }
            }
            catch (Exception ex)
            {
                DLog.Log(ex.ToString(), DLog.LogLevel.Error, true);
            }

            DLog.Log("=====================    Ending OrderAdjustments    ========================");
        }

        private static List<OrderDtlRow> ProcessEpicorOrderLine(OrderHedRow orderHedRow, OrderResponse[] ordRspArray)
        {
            #region//20190404- Amit : l Epicor Api Caller order line item
            var rsEpicorLineItems = _EpicorBusinessApi.GetOrderLineItemByOrdernum(orderHedRow.Company, orderHedRow.OrderNum);

            //foreach (SalesOrderDataSet.OrderDtlRow od in salesOrderDS.OrderDtl.Rows)
            //{
            foreach (OrderDtlRow od in rsEpicorLineItems)
            {
                #endregion
                DLog.Log("Modifying Line item 'ShipBy' date for line item: " + od.OrderLine.ToString());

                try
                {
                    od.RequestDate = orderHedRow.RequestDate;


                    foreach (var orsp in ordRspArray)
                    {
                        if (orsp.magentoLineId == od.ECCOrderLine)
                        {
                            DLog.Log("Lines match: " + orsp.magentoLineId.ToString());

                            if (orsp.pdf == null && orsp.customOptions == null) continue;

                            if (orsp.pdf != null)
                            {
                                DLog.Log("PDF from response: " + orsp.pdf);
                                od.OrderComment += "Link to artwork: " + orsp.pdf + Environment.NewLine;
                            }

                            if (orsp.customOptions != null)
                            {
                                DLog.Log("Partmatch: " + od.PartNum + " : " + orsp.sku);
                                DLog.Log("Customer Options exist for Magento line number: " + orsp.customOptions.ToString());
                                foreach (JObject obj in orsp.customOptions)
                                {
                                    String key = obj.Children().FirstOrDefault().Path.ToString();
                                    key = key.Substring(key.IndexOf('.') + 1);
                                    String value = obj.Children().FirstOrDefault().First.ToString();
                                    od.OrderComment += key + ": " + value + "  " + Environment.NewLine;
                                }
                            }
                        }
                    }

                    DLog.Log("OrderComment: " + od.OrderComment);

                    od.PickListComment = od.OrderComment;
                    od.ShipComment = od.OrderComment;
                    od.InvoiceComment = od.OrderComment;
                    od.ProFormaInvComment = od.OrderComment;
                    return rsEpicorLineItems;
                }
                catch (Exception ex)
                {
                    DLog.Log("rsLineItems: " + ex.Message);
                  
                }

            }
            return rsEpicorLineItems;
        }

        private static void ReleaseOrder(OrderHedRow orderHedRow,List<OrderRel> orderRels)
        {
            #region//20190404- Amit : Property declare to call Epicor Api Caller order relation
            var rsEpicorReleaseItems = _EpicorBusinessApi.GetOrderRelationByOrdernum(orderHedRow.Company, orderHedRow.OrderNum);
            #endregion
            Int32 iCount = 0;

            DLog.Log("reReleaseItems to process: " + orderRels.Count());

            Boolean needReleaseUpdate = false;


            foreach (var oRel in orderRels)
            {
                try
                {


                    #region//20190404- Amit : Property declare to call Epicor Api Caller order relation

                    //if (salesOrderDS.OrderRel[iCount].ShipViaCode != orderHedRow.ShipViaCode)
                    //{
                    //    needReleaseUpdate = true;

                    //    DLog.Log("Modifying Release item 'ShipVia' for release item: " + oRel.OrderRelNum.ToString() + " with shipVia: " + orderHedRow.ShipViaCode + " from: " + salesOrderDS.OrderRel[iCount].ShipViaCode);

                    //    salesOrderDS.OrderRel[iCount].ShipViaCode = orderHedRow.ShipViaCode;
                    //}
                    //salesOrderDS.OrderRel[iCount].NeedByDate = orderHedRow.NeedByDate;
                    //salesOrderDS.OrderRel[iCount].ReqDate = orderHedRow.RequestDate;

                    if (Convert.ToString(rsEpicorReleaseItems[iCount].ShipViaCode) != orderHedRow.ShipViaCode)
                    {
                        needReleaseUpdate = true;

                        DLog.Log("Modifying Release item 'ShipVia' for release item: " + oRel.OrderRelNum + " with shipVia: " + orderHedRow.ShipViaCode + " from: " + rsEpicorReleaseItems[iCount].ShipViaCode);

                        rsEpicorReleaseItems[iCount].ShipViaCode = orderHedRow.ShipViaCode;
                    }



                    iCount++;
                    #endregion
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex);
                }
            }
        }

        public static void NotifyJarod(Int32 orderNum)
        {
            DLog.StartModule();

            try
            {
                EpicorE10DataContext cs = new EpicorE10DataContext();
                var rsOrderDetails = from od in cs.OrderDtls where od.OrderNum == orderNum select od;

                foreach (OrderDtl od in rsOrderDetails)
                {
                    switch (od.PartNum)
                    {
                        case "DP-MENUS-11X17":
                            DLog.Log("Got one!  Jarod/Rachel");
                            String msg = "Order " + orderNum + " has been placed for DP-Menus-11x17";
                            DEmail.SendEmailNotification(msg + "<br />" + od.OrderComment, msg, "Dear Rachel and Jarod", "rmorgan@dotit.com;jjoyce@dotit.com;svanniman@dotit.com");
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
            }
        }


        public static Boolean DetermineOrderIsSubscription(Int32 orderNum)
        {
            DLog.StartModule();

            EpicorE10DataContext cs = new EpicorE10DataContext();

            try
            {
                var rsOrderDetails = from od in cs.OrderDtls
                                     join p in cs.Parts on od.PartNum equals p.PartNum
                                     join p_ud in cs.Part_UDs on p.SysRowID equals p_ud.ForeignSysRowID
                                     where od.OrderNum == orderNum
                                     select p_ud;

                foreach (var pud in rsOrderDetails)
                {
                    if (!pud.NonShipping_c)
                    {

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
                return false;
            }

            return true;
        }


        public static void NotifyUserIfOnCreditHold(Int32 orderNum)
        {
            DLog.StartModule();

            EpicorE10DataContext cs = new EpicorE10DataContext();

            try
            {
                OrderHed orderHed = (from oh in cs.OrderHeds where oh.OrderNum == orderNum select oh).Single();

                DLog.Log("We have the order: " + orderNum + "=" + orderHed.OrderNum);

                Customer cust = (from c in cs.Customers where c.CustNum == orderHed.CustNum select c).Single();

                DLog.Log("Customer: " + cust.CustID + ": " + cust.Name + " credit hold = " + cust.CreditHold.ToString());

                if (cust.CreditHold == true)
                {
                    String emailAddress = "";
                    //Notifications.DisectECCEmailAddress(ref emailAddress, orderHed.OrderComment);
                    emailAddress += ";ar@dotit.com";

                    DLog.Log("Notification email address for order: " + orderHed.OrderNum + " is: " + emailAddress);

                    String emailBody = "You recently placed an order (" + orderHed.ECCOrderNum + ") on an account that is on credit hold. I am sure this is simply an oversight, ";
                    emailBody += "but we will be unable to ship the order until your account is brought current.<br /><br />";
                    emailBody += "Please contact us if you need copies of invoices or if you have any questions. Your prompt ";
                    emailBody += "attention is appreciated!<br /><br />We will automatically cancel any orders that have been on hold for more than 60 days.<br /><br />";
                    emailBody += "Thank you, <br />Dot-It Accounts Receivable Department<br />ar@DotIt.com<br />800.642.3687";
                    emailBody += "<br /><br />Remit to Address:<br />Dot-It Restaurant Fulfillment<br />";
                    emailBody += "PO Box 860272<br />Minneapolis, MN 55486-0272<br /><br />";

                    String subj = "Order received, but we need a bit of help from you please.";
                    DEmail.SendEmailNotification(emailBody, subj, "Attn: Restaurant Manager / Owner", emailAddress, false, "ar@dotit.com", "Accounts Receivable");
                }
            }
            catch (Exception ex) { DLog.LogErr(ex, "Ordernum: " + orderNum); }
        }

        public static Boolean CheckForDaySpenser(Int32 orderNum)
        {
            //  Prevent distributors from shipping large quanties of DaySpensers without ordering labels

            try
            {

                EpicorE10DataContext db = (DLog.isTest) ? new EpicorE10DataContext(DLog.CS) : new EpicorE10DataContext();
                //10/04/2019
                //var OrderDtls = _EpicorBusinessApi.GetOrderLine();
                //var orderHeads = _EpicorBusinessApi.GetOrderHead();
                //var Customers = _EpicorBusinessApi.GetCustomers();
                //var ShipTos = _EpicorBusinessApi.GetShipTos(string.Empty);
                //10/04/2019
                var rsDaySpenser = from od in db.OrderDtls
                                   join oh in db.OrderHeds on od.OrderNum equals oh.OrderNum
                                   join c in db.Customers on od.CustNum equals c.CustNum
                                   join st in db.ShipTos on new { od.CustNum, oh.ShipToNum } equals new { st.CustNum, st.ShipToNum }

                                   //var rsDaySpenser = from od in OrderDtls
                                   //                   join oh in orderHeads on od.OrderNum equals oh.OrderNum
                                   //                   join c in Customers on od.CustNum equals c.CustNum
                                   //                   join st in ShipTos on new { od.CustNum, oh.ShipToNum } equals new { st.CustNum, st.ShiptoNum }

                                   where od.OrderNum == orderNum && (od.PartNum == "DAY2101" || od.PartNum == "DAY1102" || od.PartNum == "DAY1111" || od.PartNum == "DAY2114" ||
                                          od.PartNum == "DAY1101" || od.PartNum == "DAY1112" || od.PartNum == "DAY1175" || od.PartNum == "DAY2108") && od.OrderQty > 12
                                   select new { od.OrderQty, od.LineDesc, od.PartNum, c.Name, oh.UseOTS, stName = st.Name, otsName = oh.OTSName };

                if (rsDaySpenser.Count() > 0)
                {
                    String body = "Order No: " + orderNum.ToString() + " has been placed with a quantity of " + rsDaySpenser.First().OrderQty.ToString("0") + " of " + rsDaySpenser.First().PartNum + " - " + rsDaySpenser.First().LineDesc;
                    body += Environment.NewLine + Environment.NewLine + "Customer is: ";
                    if (rsDaySpenser.First().UseOTS) body += rsDaySpenser.First().otsName;
                    else body += rsDaySpenser.First().stName;


                    //DEmail.SendEmailNotification(body, body, "Dear Dot It", "csr@dotit.com;ksmith@dotit.com;rtrafford@dotit.com");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                DLog.Log("CheckForDaySpenser exception: " + ex.Message, DLog.LogLevel.Error, true);
                return false;
            }
        }

        //public static Boolean CheckForDaySpenser(Int32 orderNum)
        //{
        //    //  Prevent distributors from shipping large quanties of DaySpensers without ordering labels

        //    try
        //    {
        //        EpicorE10DataContext db = new EpicorE10DataContext();

        //        var rsDaySpenser = from od in db.OrderDtls
        //                           join oh in db.OrderHeds on od.OrderNum equals oh.OrderNum
        //                           join c in db.Customers on od.CustNum equals c.CustNum
        //                           join st in db.ShipTos on new { od.CustNum, oh.ShipToNum } equals new { st.CustNum, st.ShipToNum }
        //                           where od.OrderNum == orderNum && (od.PartNum == "DAY2101" || od.PartNum == "DAY1102" || od.PartNum == "DAY1111" || od.PartNum == "DAY2114" ||
        //                                  od.PartNum == "DAY1101" || od.PartNum == "DAY1112" || od.PartNum == "DAY1175" || od.PartNum == "DAY2108") && od.OrderQty > 12
        //                           select new { od.OrderQty, od.LineDesc, od.PartNum, c.Name, oh.UseOTS, stName = st.Name, otsName = oh.OTSName };

        //        if (rsDaySpenser.Count() > 0)
        //        {
        //            String body = "Order No: " + orderNum.ToString() + " has been placed with a quantity of " + rsDaySpenser.First().OrderQty.ToString("0") + " of " + rsDaySpenser.First().PartNum + " - " + rsDaySpenser.First().LineDesc;
        //            body += Environment.NewLine + Environment.NewLine + "Customer is: ";
        //            if (rsDaySpenser.First().UseOTS) body += rsDaySpenser.First().otsName;
        //            else body += rsDaySpenser.First().stName;

        //            DEmail.SendEmailNotification(body, body, "Dear Dot It", "csr@dotit.com;ksmith@dotit.com;rtrafford@dotit.com");
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        DLog.Log("CheckForDaySpenser exception: " + ex.Message, DLog.LogLevel.Error, true);
        //        return false;
        //    }
        //}



        public static Int32 SplitComment(ref String line)
        {
            String sLineNum = line.Substring(1, line.IndexOf(']'));
            line = line.Substring(line.IndexOf(']') + 1);
            return Convert.ToInt32(sLineNum);
        }


        public static OrderResponse[] GetMagentoLineItemDetails(Int32 orderNumber)
        {
            DLog.StartModule();

            try
            {
                var url = DataStructures.GetAppConfigSetting("orderApi", "Magento", DLog.isTest) + orderNumber.ToString();
                DLog.Log("addline Item url: " + url);
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                using (var response = webrequest.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    String json = reader.ReadToEnd();

                    DLog.Log("apiResponse json: " + json);

                    OrderAPIResponse apiResponse = JsonConvert.DeserializeObject<OrderAPIResponse>(json);

                    if (apiResponse.code != 200)
                    {
                        DLog.Log("GetMagentoLineItemDetails for order: " + orderNumber.ToString() + " apiResponse.code error: " + json, DLog.LogLevel.Error);
                        return null;
                    }

                    foreach (OrderResponse orsp in apiResponse.response)
                    {
                        DLog.Log("svn444:  " + orsp.pdf);

                        if (orsp.pdf == @"https://www.dotit.com/")
                        {
                            orsp.pdf = url;
                            DLog.Log("svn555: " + orsp.pdf);
                            //DLog.Log("GetMagentoLineItemDetails for order: " + orderNumber.ToString() + " PDF is NOT ready from Chili: " + orsp.pdf);
                            //return null;
                        }
                    }

                    apiResponse.response[0].customerEmail = apiResponse.customerData.customerEmail;

                    return apiResponse.response;
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Error retrieving line item details from Magento: " + ex.ToString(), DLog.LogLevel.Error, true);
                return null;
            }
        }


        public class OrderAPIResponse
        {
            public Int32 code { get; set; }
            public String message { get; set; }
            //public Int32 orderNum { get; set; }
            public CustomerData customerData { get; set; }
            public OrderResponse[] response { get; set; }
        }


        public class OrderResponse
        {
            //public Int32 lineId { get; set; }
            public String customerEmail { get; set; }
            public Int32 magentoLineId { get; set; }
            public String sku { get; set; }
            public String quantity { get; set; }
            public String pdf { get; set; }
            public Boolean isPDFComing { get; set; }
            public JArray customOptions { get; set; }
            public OrderResponse()
            {
                isPDFComing = false;
            }
        }

        public class CustomerData
        {
            public String customerEmail { get; set; }
            public String customerFirstName { get; set; }
            public String customerLastName { get; set; }
        }

        public class CustomOptions
        {
            public String key { get; set; }
            public String value { get; set; }
        }

    }


    public static class JTokenExt
    {
        public static Dictionary<string, object>
             Bagify(this JToken obj, string name = null)
        {
            name = name ?? "obj";
            if (obj is JObject)
            {
                var asBag =
                    from prop in (obj as JObject).Properties()
                    let propName = prop.Name
                    let propValue = prop.Value is JValue
                        ? new Dictionary<string, object>()
                            {
                            {prop.Name, prop.Value}
                            }
                        : prop.Value.Bagify(prop.Name)
                    select new KeyValuePair<string, object>(propName, propValue);
                return asBag.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }
            if (obj is JArray)
            {
                var vals = (obj as JArray).Values();
                var alldicts = vals
                    .SelectMany(val => val.Bagify(name))
                    .Select(x => x.Value)
                    .ToArray();
                return new Dictionary<string, object>()
            {
                {name, (object)alldicts}
            };
            }
            if (obj is JValue)
            {
                return new Dictionary<string, object>()
            {
                {name, (obj as JValue)}
            };
            }
            return new Dictionary<string, object>()
        {
            {name, null}
        };
        }
    }

}
