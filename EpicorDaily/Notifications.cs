using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotCommon;
using DotitBllDal;
using EpicorDaily.Model;
//using DotitBllDal;


namespace EpicorDaily
{
    public class Notifications
    {        

        public static void SendShippingNotification()
        {
            DLog.StartModule();
            
            EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
          
            String exceptionKeeper = "";
            String baseEmailText = File.ReadAllText(@"templates\dotitshipping.html");

            DateTime dtStart = DateTime.Now.AddDays(-3);
            if (DLog.isTest) dtStart = dtStart.AddYears(-2);           

          
            var rsToSend = from sh_ud in cs.ShipHead_UDs where sh_ud.ShipmentEmailSent_c == false select sh_ud;

            Int32 iTempCount = 0;
            Int32 failingPackNum = 0;


            foreach (ShipHeadModel shud in rsToSend)
            {
                String emailText = baseEmailText;

                try
                {
                    failingPackNum = shud.PackNum;

                    var shipHead = (from sh in cs.ShipHeads
                                    join sd in cs.ShipDtls on sh.PackNum equals sd.PackNum
                                    join oh in cs.OrderHeds on sd.OrderNum equals oh.OrderNum
                                    join st in cs.ShipTos on new { cn = oh.ShipToCustNum, cs = oh.ShipToNum } equals new { cn = st.CustNum, cs = st.ShipToNum }
                                    join c in cs.Customers on sh.CustNum equals c.CustNum
                                    join cg in cs.CustGrups on c.GroupCode equals cg.GroupCode
                                    join cgud in cs.CustGrup_UDs on cg.SysRowID equals cgud.ForeignSysRowID
                                    join sv in cs.ShipVias on sh.ShipViaCode equals sv.ShipViaCode
                                    where sh.SysRowID == shud.ForeignSysRowID && sh.TrackingNumber != "" && sh.ShipDate > dtStart
                                    group new { sd.PackLine, sd.OrderLine, sd.PartNum, sd.LineDesc, sd.IUM, sd.OurInventoryShipQty, sd.OurJobShipQty, sd.DocExtPrice }
                                    by new
                                    {
                                        sh.PackNum,
                                        sh.SysRowID,
                                        sh.ShipDate,
                                        sd.OrderNum,
                                        sh.TrackingNumber,
                                        oh.UseOTS,
                                        oh.OTSName,
                                        oh.ShipToCustNum,
                                        oh.CustNum,
                                        oh.ShipToNum,
                                        st.Name,
                                        custEmail = c.EMailAddress,
                                        stEmail = st.EMailAddress,
                                        shipViaCarrier = sv.Carrier,
                                        shipVia = sv.WebDesc,
                                        orderComment = oh.OrderComment,
                                        eccOrderNum = oh.ECCOrderNum,
                                        cgud.eCommURL_c
                                    }
                                    into g
                                    select new
                                    {
                                        packNum = g.Key.PackNum,
                                        shipDate = g.Key.ShipDate,
                                        sysRowId = g.Key.SysRowID,
                                        useOTS = g.Key.UseOTS,
                                        otsName = g.Key.OTSName,
                                        shName = g.Key.Name,
                                        orderNum = g.Key.OrderNum,
                                        trackingNum = g.Key.TrackingNumber,
                                        custEmail = g.Key.custEmail,
                                        stEmail = g.Key.stEmail,
                                        custId = g.Key.ShipToCustNum,
                                        custNum = g.Key.CustNum,
                                        shipVia = g.Key.shipVia,
                                        shipViaCarrier = g.Key.shipViaCarrier,
                                        orderComment = g.Key.orderComment,
                                        eccOrderNum = g.Key.eccOrderNum,
                                        eCommURL = g.Key.eCommURL_c,
                                        list = g.ToList()
                                    }).Single();




                    if (shipHead.custNum == 8822 | shipHead.custNum == 1 || shipHead.custNum == 7600 || shipHead.custNum == 50403)       //  This is the FREEB!RDS Swag account, National Checking or Coke
                    {
                        DLog.Log("Shipping Notification being skipped because it is FREEB!RDS App Swag account, NCCO or Coke: " + shipHead.custId);
                        SetEmailSentShipment(shipHead.packNum);
                        continue;
                    }

                    if (shipHead.shipVia.ToLower() == "spg1" || shipHead.shipVia.ToLower() == "spl1")
                    {
                        DLog.Log("Shipping Notification being skipped because of UPS SurePost: " + shipHead.shipVia);
                        SetEmailSentShipment(shipHead.packNum);
                        continue;
                    }

                    String emailAddress = "";
                    if (String.IsNullOrWhiteSpace(shipHead.eccOrderNum))
                    {
                        emailAddress = shipHead.stEmail;
                        if (String.IsNullOrWhiteSpace(emailAddress)) emailAddress = shipHead.custEmail;
                    }
                    else
                    {
                        DisectECCEmailAddress(ref emailAddress, shipHead.orderComment);
                    }

                    if (String.IsNullOrWhiteSpace(emailAddress))
                    {


                        DLog.Log("There is no email address for order number: " + shipHead.orderNum);
                        SetEmailSentShipment(shipHead.packNum);
                        continue;
                    }

                    String customerName = shipHead.shName;
                    if (shipHead.useOTS) customerName = shipHead.otsName;

                    exceptionKeeper = "Order: " + shipHead.orderNum + " Pack: " + shipHead.packNum + " Customer: " + shipHead.custId;

                    String orderNumber = shipHead.orderNum.ToString();
                    if (!String.IsNullOrWhiteSpace(shipHead.eccOrderNum)) orderNumber = shipHead.eccOrderNum + " (" + orderNumber + ")";

                    emailText = emailText.Replace("[ordernum]", orderNumber);
                    emailText = emailText.Replace("[orderdate]", Convert.ToDateTime(shipHead.shipDate).ToString("M/d/yyyy"));
                    emailText = emailText.Replace("[shiptoaddress]", BuildShipToAddress(shipHead.orderNum));
                    emailText = emailText.Replace("[customergroupurl]", shipHead.eCommURL);

                    //  No email address or tracking number, mark as sent and press on
                    if (!String.IsNullOrWhiteSpace(emailAddress) && !String.IsNullOrWhiteSpace(shipHead.trackingNum))
                    {
                        String emailMessage = "<p>Thank YOU for shopping with Dot It Restauruant Fulfillment.</p><p>Your order number " + shipHead.orderNum + " has been packed and will be picked up";
                        if (!String.IsNullOrWhiteSpace(shipHead.shipVia)) emailText = emailText.Replace("[shipvia]", "Shipped Via: " + shipHead.shipVia);
                        if (!String.IsNullOrWhiteSpace(shipHead.trackingNum))
                        {
                            DLog.Log("ship via code is: " + shipHead.shipViaCarrier);

                            String buttonText = "";

                            switch (shipHead.shipViaCarrier.ToUpper())
                            {
                                case "UPS":
                                    buttonText = BuildEmailButton(shipHead.trackingNum, "wwwapps.ups.com/WebTracking/track?track=yes&trackNums=" + shipHead.trackingNum);
                                    break;
                                case "FEDEX":
                                    buttonText = BuildEmailButton(shipHead.trackingNum, "www.fedex.com/apps/fedextrack/?action=track&trackingnumber=" + shipHead.trackingNum);
                                    break;
                                case "USPS":
                                    //emailText.Replace("[url]", "wwwapps.ups.com/WebTracking/track?track=yes&trackNums=" + shipHead.trackingNum);
                                    break;
                                default:
                                    //emailMessage += shipHead.trackingNum;
                                    break;
                            }

                            if (!String.IsNullOrWhiteSpace(buttonText)) emailText = emailText.Replace("[trackingbutton]", buttonText);
                            else emailText = emailText.Replace("[trackingbutton]", "");
                        }
                        //emailMessage += "</a><br/><p>In the package(s) are the following items:</p><br/><table><tr><td style='width:120px;'>Item</td><td style='width:20px;text-align:center;'>Qty</td>";
                        //emailMessage += "<td style='width:20px;text-align:center;'>UOM</td><td style='width:320px;'>Description</td></tr>";

                        String totalLineText = "";

                        foreach (var shipDtl in shipHead.list)
                        {
                            Int32 qty = Convert.ToInt32(shipDtl.OurInventoryShipQty + shipDtl.OurJobShipQty);
                            String lineText = BuildShippingLineText();
                            lineText = lineText.Replace("[partdescription]", shipDtl.LineDesc);
                            lineText = lineText.Replace("[partnumber]", shipDtl.PartNum);
                            lineText = lineText.Replace("[qty]", qty.ToString());
                            lineText = lineText.Replace("[price]", shipDtl.DocExtPrice.ToString("#,##0.00"));
                            //emailMessage += "<tr><td>" + shipDtl.PartNum + "</td><td style='text-align:center;'>" + qty.ToString() + "</td><td style='text-align:center;'>"
                            //             + shipDtl.IUM + "</td><td>" + shipDtl.LineDesc + "</td></tr>";

                            totalLineText += lineText;
                        }

                        emailText = emailText.Replace("[linetext]", totalLineText);




                        //emailMessage += "</table><br/><br/>";

                        var rsOrderDetails = from od in cs.OrderDtls where od.OrderNum == shipHead.orderNum && od.OpenLine == true select od;

                        //emailMessage += "<p>Thanks Again!</p><p>Your Dot It Team</p><br/>";


                        if (DLog.isTest)
                        {
                            emailAddress = "svanniman@dotit.com";       //  For testing purposes
                        }

                        if (++iTempCount <= 2)
                        {
                            emailAddress += ";svanniman@dotit.com";       //  For testing purposes
                        }

                        DEmail.SendJustEmailNotification(emailText, "We're shipping your order", emailAddress);

                        DLog.Log("Shipping Notification sent for order " + shipHead.orderNum + " for " + customerName + " " + emailAddress + " PackNum:" + shipHead.packNum);

                    }
                    else
                    {
                        DLog.Log("************  Shipping Notification NOT SENT for order " + shipHead.orderNum + " for: " + customerName + " email: " + emailAddress + " track: " + shipHead.trackingNum);
                    }

                    SetEmailSentShipment(shipHead.packNum);
                }
                catch (Exception ex)
                {
                    DLog.Log("Error sending shipping notification email for " + exceptionKeeper + " exception: " + ex.ToString(), DLog.LogLevel.Error);
                    SetEmailSentShipment(failingPackNum);
                }
            }


            //  Mark email sent if older than 3 days - prevents older notifications from going out  in case date is no longer checked.
            //10/04/2019
            List<Int32> rsOldNotifications = (from sh in cs.ShipHeads
                                              join shud in cs.ShipHead_UDs on sh.SysRowID equals shud.ForeignSysRowID
                                              where sh.ShipHead_UD.ShipmentEmailSent_c == false
                                              select sh.PackNum).ToList<Int32>();


            DLog.Log(rsOldNotifications.Count().ToString() + " Packs to be marked as notification sent.");

            foreach (Int32 pack in rsOldNotifications)
            {
                SetEmailSentShipment(pack);
                DLog.Log("Old notification set to sent for packnum: " + pack);
            }

            DLog.EndModule();
        }


        //public static void SendInvoiceNotifications()
        //{
        //    DLog.StartModule();

        //    EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
        //    String exceptionKeeper = "";
        //    String baseEmailText = File.ReadAllText(@"templates\dotitinvoice.html");

        //    DateTime dtStart = DateTime.Now.AddDays(-3);
        //    if (DLog.isTest) dtStart = dtStart.AddYears(-2);


        //var rsToSend = from ih_ud in cs.InvcHead_UDs where ih_ud.InvoiceNotificationSent_c == false select ih_ud;

        //    Int32 iTempCount = 0;
        //    Int32 failingInvoiceNum = 0;


        //    foreach (InvcHead_UD ihud in rsToSend)
        //    {
        //        String emailText = baseEmailText;

        //        try
        //        {
        //            failingInvoiceNum = ihud.InvcHead.InvoiceNum;

        //            var invcHead = (from ih in cs.InvcHeads
        //                            join id in cs.InvcDtls on ih.InvoiceNum equals id.InvoiceNum
        //                            join c in cs.Customers on ih.CustNum equals c.CustNum
        //                            join cud in cs.Customer_UDs on c.SysRowID equals cud.ForeignSysRowID

        //                            where ih.SysRowID == ihud.ForeignSysRowID && ih.InvoiceDate > dtStart && cud.notifyviaemail_c == true
        //                            group new { id.InvoiceLine, id.PartNum, id.LineDesc }
        //                            by new
        //                            {
        //                                ih.InvoiceNum
        //                            } into g
        //                            select new
        //                            {
        //                                invoiceNum = g.Key.InvoiceNum,
        //                                details = g.ToList()
        //                            }).Single();

        //            //var shipHead = (from sh in cs.ShipHeads
        //            //                join sd in cs.ShipDtls on sh.PackNum equals sd.PackNum
        //            //                join oh in cs.OrderHeds on sd.OrderNum equals oh.OrderNum
        //            //                join st in cs.ShipTos on new { cn = oh.ShipToCustNum, cs = oh.ShipToNum } equals new { cn = st.CustNum, cs = st.ShipToNum }
        //            //                join c in cs.Customers on sh.CustNum equals c.CustNum
        //            //                join cg in cs.CustGrups on c.GroupCode equals cg.GroupCode
        //            //                join cgud in cs.CustGrup_UDs on cg.SysRowID equals cgud.ForeignSysRowID
        //            //                join sv in cs.ShipVias on sh.ShipViaCode equals sv.ShipViaCode
        //            //                where sh.SysRowID == shud.ForeignSysRowID && sh.TrackingNumber != "" && sh.ShipDate > dtStart
        //            //                //&& oh.ShipViaCode != "SPG1" && oh.ShipViaCode != "SPL1" && oh.CustNum != 8822           //  Exclude SurePost and App Swag
        //            //                //where oh.OrderNum == 1013    //TESTING ONLY*************
        //            //                group new { sd.PackLine, sd.OrderLine, sd.PartNum, sd.LineDesc, sd.IUM, sd.OurInventoryShipQty, sd.OurJobShipQty, sd.DocExtPrice }
        //            //                by new
        //            //                {
        //            //                    sh.PackNum,
        //            //                    sh.SysRowID,
        //            //                    sh.ShipDate,
        //            //                    sd.OrderNum,
        //            //                    sh.TrackingNumber,
        //            //                    oh.UseOTS,
        //            //                    oh.OTSName,
        //            //                    oh.ShipToCustNum,
        //            //                    oh.CustNum,
        //            //                    oh.ShipToNum,
        //            //                    st.Name,
        //            //                    custEmail = c.EMailAddress,
        //            //                    stEmail = st.EMailAddress,
        //            //                    shipViaCarrier = sv.Carrier,
        //            //                    shipVia = sv.WebDesc,
        //            //                    orderComment = oh.OrderComment,
        //            //                    eccOrderNum = oh.ECCOrderNum,
        //            //                    cgud.eCommURL_c
        //            //                }
        //            //                  into g
        //            //                select new
        //            //                {
        //            //                    packNum = g.Key.PackNum,
        //            //                    shipDate = g.Key.ShipDate,
        //            //                    sysRowId = g.Key.SysRowID,
        //            //                    useOTS = g.Key.UseOTS,
        //            //                    otsName = g.Key.OTSName,
        //            //                    shName = g.Key.Name,
        //            //                    orderNum = g.Key.OrderNum,
        //            //                    trackingNum = g.Key.TrackingNumber,
        //            //                    custEmail = g.Key.custEmail,
        //            //                    stEmail = g.Key.stEmail,
        //            //                    custId = g.Key.ShipToCustNum,
        //            //                    custNum = g.Key.CustNum,
        //            //                    shipVia = g.Key.shipVia,
        //            //                    shipViaCarrier = g.Key.shipViaCarrier,
        //            //                    orderComment = g.Key.orderComment,
        //            //                    eccOrderNum = g.Key.eccOrderNum,
        //            //                    eCommURL = g.Key.eCommURL_c,
        //            //                    list = g.ToList()
        //            //                }).Single();

        //            if (invcHead.invoiceNum == 0)
        //            {
        //                DLog.Log("Invoice Notification being skipped because it is FREEB!RDS App Swag account, NCCO or Coke: " + shipHead.custId);
        //                SetEmailSentShipment(shipHead.packNum);
        //                continue;
        //            }

        //            if (shipHead.shipVia.ToLower() == "spg1" || shipHead.shipVia.ToLower() == "spl1")
        //            {
        //                DLog.Log("Shipping Notification being skipped because of UPS SurePost: " + shipHead.shipVia);
        //                SetEmailSentShipment(shipHead.packNum);
        //                continue;
        //            }

        //            String emailAddress = "";
        //            if (String.IsNullOrWhiteSpace(shipHead.eccOrderNum))
        //            {
        //                emailAddress = shipHead.stEmail;
        //                if (String.IsNullOrWhiteSpace(emailAddress)) emailAddress = shipHead.custEmail;
        //            }
        //            else
        //            {
        //                DisectECCEmailAddress(ref emailAddress, shipHead.orderComment);
        //            }

        //            if (String.IsNullOrWhiteSpace(emailAddress))
        //            {
        //                DLog.Log("There is no email address for order number: " + shipHead.orderNum);
        //                SetEmailSentShipment(shipHead.packNum);
        //                continue;
        //            }

        //            String customerName = shipHead.shName;
        //            if (shipHead.useOTS) customerName = shipHead.otsName;

        //            exceptionKeeper = "Order: " + shipHead.orderNum + " Pack: " + shipHead.packNum + " Customer: " + shipHead.custId;

        //            String orderNumber = shipHead.orderNum.ToString();
        //            if (!String.IsNullOrWhiteSpace(shipHead.eccOrderNum)) orderNumber = shipHead.eccOrderNum + " (" + orderNumber + ")";

        //            emailText = emailText.Replace("[ordernum]", orderNumber);
        //            emailText = emailText.Replace("[orderdate]", Convert.ToDateTime(shipHead.shipDate).ToString("M/d/yyyy"));
        //            emailText = emailText.Replace("[shiptoaddress]", BuildShipToAddress(shipHead.orderNum));
        //            emailText = emailText.Replace("[customergroupurl]", shipHead.eCommURL);

        //            //  No email address or tracking number, mark as sent and press on
        //            if (!String.IsNullOrWhiteSpace(emailAddress) && !String.IsNullOrWhiteSpace(shipHead.trackingNum))
        //            {
        //                //String emailMessage = "<p>Thank YOU for shopping with Dot It Restauruant Fulfillment.</p><p>Your order number " + shipHead.orderNum + " has been packed and will be picked up";
        //                if (!String.IsNullOrWhiteSpace(shipHead.shipVia)) emailText = emailText.Replace("[shipvia]", "Shipped Via: " + shipHead.shipVia);
        //                if (!String.IsNullOrWhiteSpace(shipHead.trackingNum))
        //                {
        //                    DLog.Log("ship via code is: " + shipHead.shipViaCarrier);

        //                    String buttonText = "";

        //                    switch (shipHead.shipViaCarrier.ToUpper())
        //                    {
        //                        case "UPS":
        //                            buttonText = BuildEmailButton(shipHead.trackingNum, "wwwapps.ups.com/WebTracking/track?track=yes&trackNums=" + shipHead.trackingNum);
        //                            break;
        //                        case "FEDEX":
        //                            buttonText = BuildEmailButton(shipHead.trackingNum, "www.fedex.com/apps/fedextrack/?action=track&trackingnumber=" + shipHead.trackingNum);
        //                            break;
        //                        case "USPS":
        //                            //emailText.Replace("[url]", "wwwapps.ups.com/WebTracking/track?track=yes&trackNums=" + shipHead.trackingNum);
        //                            break;
        //                        default:
        //                            //emailMessage += shipHead.trackingNum;
        //                            break;
        //                    }

        //                    if (!String.IsNullOrWhiteSpace(buttonText)) emailText = emailText.Replace("[trackingbutton]", buttonText);
        //                    else emailText = emailText.Replace("[trackingbutton]", "");
        //                }
        //                //emailMessage += "</a><br/><p>In the package(s) are the following items:</p><br/><table><tr><td style='width:120px;'>Item</td><td style='width:20px;text-align:center;'>Qty</td>";
        //                //emailMessage += "<td style='width:20px;text-align:center;'>UOM</td><td style='width:320px;'>Description</td></tr>";

        //                String totalLineText = "";

        //                foreach (var shipDtl in shipHead.list)
        //                {
        //                    Int32 qty = Convert.ToInt32(shipDtl.OurInventoryShipQty + shipDtl.OurJobShipQty);
        //                    String lineText = BuildShippingLineText();
        //                    lineText = lineText.Replace("[partdescription]", shipDtl.LineDesc);
        //                    lineText = lineText.Replace("[partnumber]", shipDtl.PartNum);
        //                    lineText = lineText.Replace("[qty]", qty.ToString());
        //                    lineText = lineText.Replace("[price]", shipDtl.DocExtPrice.ToString("#,##0.00"));
        //                    //emailMessage += "<tr><td>" + shipDtl.PartNum + "</td><td style='text-align:center;'>" + qty.ToString() + "</td><td style='text-align:center;'>"
        //                    //             + shipDtl.IUM + "</td><td>" + shipDtl.LineDesc + "</td></tr>";

        //                    totalLineText += lineText;
        //                }

        //                emailText = emailText.Replace("[linetext]", totalLineText);




        //                //emailMessage += "</table><br/><br/>";

        //                //var rsOrderDetails = from od in cs.OrderDtls where od.OrderNum == shipHead.orderNum && od.OpenLine == true select od;

        //                //emailMessage += "<p>Thanks Again!</p><p>Your Dot It Team</p><br/>";


        //                if (DLog.isTest)
        //                {
        //                    emailAddress = "svanniman@dotit.com";       //  For testing purposes
        //                }

        //                if (++iTempCount <= 2)
        //                {
        //                    emailAddress += ";svanniman@dotit.com";       //  For testing purposes
        //                }

        //                DEmail.SendJustEmailNotification(emailText, "We're shipping your order", emailAddress);

        //                DLog.Log("Shipping Notification sent for order " + shipHead.orderNum + " for " + customerName + " " + emailAddress + " PackNum:" + shipHead.packNum);

        //            }
        //            else
        //            {
        //                DLog.Log("************  Shipping Notification NOT SENT for order " + shipHead.orderNum + " for: " + customerName + " email: " + emailAddress + " track: " + shipHead.trackingNum);
        //            }

        //            SetEmailSentShipment(shipHead.packNum);
        //        }
        //        catch (Exception ex)
        //        {
        //            DLog.Log("Error sending shipping notification email for " + exceptionKeeper + " exception: " + ex.ToString(), DLog.LogLevel.Error);
        //            SetEmailSentShipment(failingPackNum);
        //        }
        //    }


        //    //  Mark email sent if older than 3 days - prevents older notifications from going out  in case date is no longer checked.
        //    List<Int32> rsOldNotifications = (from sh in cs.ShipHeads
        //                                      join shud in cs.ShipHead_UDs on sh.SysRowID equals shud.ForeignSysRowID
        //                                      where sh.ShipHead_UD.ShipmentEmailSent_c == false
        //                                      select sh.PackNum).ToList<Int32>();

        //    DLog.Log(rsOldNotifications.Count().ToString() + " Packs to be marked as notification sent.");

        //    foreach (Int32 pack in rsOldNotifications)
        //    {
        //        SetEmailSentShipment(pack);
        //        DLog.Log("Old notification set to sent for packnum: " + pack);
        //    }

        //    DLog.EndModule();
        //}


        private static String BuildShippingLineText()
        {
            String lineText = "<tr style='text - align:center; font - weight: bold; border - style:solid; border - width: 1px; border - color: #e3e3e3;'>";
            lineText += "<td><p>[partdescription]</p></td><td>[partnumber]</td><td align='center'>[qty]</td><td align='right'>[price]</td>";
            return lineText;
        }


        private static String BuildInvoiceLineText()
        {
            //String lineText = "<tr style='text - align:center; font - weight: bold; border - style:solid; border - width: 1px; border - color: #e3e3e3;'>";
            //lineText += "<td><p>[partdescription]</p></td><td>[partnumber]</td><td align='center'>[qty]</td><td align='right'>[price]</td>";
            //return lineText;
            return "";
        }

        private static String BuildShipToAddress(Int32 orderNum)
        {
            String shipToAddress = "";
            try
            {
                EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

                OrderHeadModel ord = null;

                using (_EpicorBusinessApi = new EpicorBusinessApi())
                {
                    OrderHed ord = (from o in cs.OrderHeds where o.OrderNum == orderNum select o).Single();

                    if (ord.UseOTS)
                    {
                        shipToAddress = ord.OTSName + "<br />" + ord.OTSAddress1 + "<br />";
                        if (!String.IsNullOrWhiteSpace(ord.OTSAddress2)) shipToAddress += ord.OTSAddress2 + "<br />";
                        shipToAddress += ord.OTSCity + ", " + ord.OTSState + "  " + ord.OTSZIP + "<br /><br />";
                    }
                    else
                    {
                        ShipTo shipTo = (from st in cs.ShipTos where st.CustNum == ord.CustNum && st.ShipToNum == ord.ShipToNum select st).Single();
                        shipToAddress = shipTo.Name + "<br />" + shipTo.Address1 + "<br />";
                        if (!String.IsNullOrWhiteSpace(shipTo.Address2)) shipToAddress += shipTo.Address2 + "<br />";
                        shipToAddress += shipTo.City + ", " + shipTo.State + "  " + shipTo.ZIP + "<br /><br />";
                    }
                }
            }
            catch (Exception ex)
            {
            }


            return shipToAddress;
        }


        private static void SetEmailSentShipment(Int32 packNum)
        {
            try
            {
                EpicorE10DataContext es = E10.CustomTableMaint();

                ShipHead_UD sud = (from sh in es.ShipHeads
                                   join shud in es.ShipHead_UDs on sh.SysRowID equals shud.ForeignSysRowID
                                   where sh.PackNum == packNum
                                   select shud).Single();

                sud.ShipmentEmailSent_c = true;

                es.SubmitChanges();

                DLog.Log(packNum.ToString() + " pack has been marked as shipped.");
            }
            catch (Exception ex)
            {
                DLog.Log(ex.ToString(), DLog.LogLevel.Error);
            }
        }


        private static void SetEmailSentInvoice(Int32 invoiceNum)
        {
            try
            {
                EpicorE10DataContext es = E10.CustomTableMaint();

                InvcHead_UD ihud = (from ih in es.InvcHeads
                                    join iud in es.InvcHead_UDs on ih.SysRowID equals iud.ForeignSysRowID
                                    where ih.InvoiceNum == invoiceNum
                                    select iud).Single();

                ihud.InvoiceNotificationSent_c = true;

                es.SubmitChanges();

                DLog.Log(invoiceNum.ToString() + " invoice has been marked as shipped.");
            }
            catch (Exception ex)
            {
                DLog.Log(ex.ToString(), DLog.LogLevel.Error);
            }
        }


        public static void DisectECCEmailAddress(ref String emailAddress, String orderComment)
        {
            DLog.Log("*** DisectingECCEmailAddress: " + emailAddress + "    comment: " + orderComment);
            Int32 iStart = orderComment.IndexOf("Email: ");
            Int32 iEnd = orderComment.IndexOf("<EmailEnd>");
            Int32 iLen = 0;

            if (iStart < 0) return;

            if (iEnd > 0)
            {
                iLen = iEnd - iStart - 7;
            }
            else
            {
                iLen = orderComment.Length - iStart - 7;
            }

            String tempEmail = orderComment.Substring(iStart + 7, iLen).Trim();

            if (tempEmail.Contains(Environment.NewLine))
            {
                DLog.Log("yes: " + orderComment + " still contains a carriage return");
                tempEmail = tempEmail.Substring(0, tempEmail.IndexOf(Environment.NewLine));
            }

            if (!tempEmail.Contains("@") || !tempEmail.Contains("."))
            {
                DLog.Log("Disected email address only to find there is not a valid email address: ######  " + tempEmail);
                return;
            }

            emailAddress = tempEmail;
        }


        private static String BuildEmailButton(String label, String url, String leader = "")
        {
            String dynamicHTML = "<table border='0' cellspacing='0' cellpadding='20' align='left' style='background-color:#b5bdc1'><tr>";
            if (!String.IsNullOrWhiteSpace(leader)) dynamicHTML += "<td>" + leader + "</td>";
            dynamicHTML += "<td><a style='text-decoration:none;tex-decoration-color:#2c2c2c;' href='https://" + url + "'><font face='Boing-Bold, Arial, snas-serif'>";
            dynamicHTML += label + "</font></a></td></tr></table>";

            return dynamicHTML;
        }


    }

}