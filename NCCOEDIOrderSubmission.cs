using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;

using DotCommon;
using DotitBllDal;


namespace EpicorDaily
{
    public class NCCOEDIOrderSubmission
    {
        Boolean isShipFrom = false;
        Boolean isShipTo = false;

        public class SessionInfo
        {
            public Boolean result { get; set; }
            public String resultMessage { get; set; }
            public String sessionGuid { get; set; }
        }

        public void EDIOrderSubmission()
        {
            DLog.StartModule();

            try
            {
                String filePath = DataStructures.GetAppConfigSetting("NCCOEDIFilePath", "E10BLL", DLog.isTest);
                String filePathHistory = filePath + @"History\";

                DLog.Log("File path for NCCO orders: " + filePath);

                DirectoryInfo di = new DirectoryInfo(filePath);
                FileInfo[] files = di.GetFiles("*.new");

                if (files.Length <= 0)
                {
                    DLog.Log("There are no files to be processed at this time. ");
                    return;
                }

                DLog.Log("There are " + files.Length.ToString() + " files to be processed");


                SessionInfo si = new SessionInfo();

                using (var client = new WSPartner.DotitPartnerSoapClient("DotitPartnerSoap"))
                {
                    si = EstablishSession();

                    DLog.Log("Session results: " + si.result + " " + si.resultMessage);
                    DLog.Log("Session with connection: " + si.sessionGuid);

                    if (!si.result) return;

                    foreach (FileInfo f in files)
                    {
                        if (!File.Exists(f.FullName))
                        {
                            DLog.Log("EDI file to process does not exist: " + f.FullName, DLog.LogLevel.Error, true);
                            continue;
                        }

                        String dt = DateTime.Now.ToString("yyMMddHHmmss");
                        String newFileName = dt.Substring(0, 2) + "-" + dt.Substring(2, 2) + "-" + dt.Substring(4, 2) + "-" + dt.Substring(6, 2) + "-" + dt.Substring(8, 2) + "-" + dt.Substring(10, 2);

                        if (DLog.isTest)
                        {
                            File.Copy(f.FullName, filePath + newFileName + ".processing");          //  Simply to allow repetitve tests without having to rename original file
                        }
                        else
                        {
                            File.Move(f.FullName, filePath + newFileName + ".processing");
                        }

                        Thread.Sleep(1000);

                        List<EDIOrder> orders = DisectEDIFile(filePath + newFileName + ".processing");

                        foreach (EDIOrder ord in orders)
                        {
                            DLog.Log("Preprocessing order: " + ord.purchaseOrder);
                        }

                        List<WSOrder.SalesOrder> returnSO = ProcessOrders(orders, si);

                        OrderNotification(returnSO);

                        File.Move(filePath + newFileName + ".processing", filePath + @"History\" + newFileName + ".processed");

                    }

                }

                

            }
            catch (Exception ex)
            {
                DLog.Log("EDIOrderSubmission: " + ex.ToString(), DLog.LogLevel.Error, true);
            }

            DLog.EndModule();
        }


        private List<EDIOrder> DisectEDIFile(String fileName)
        {
            DLog.StartModule();

            Int32 lineNumber = 0;

            try
            {
                String[] lines;

                lines = File.ReadAllLines(fileName);
                List<EDIOrder> listOrder = new List<EDIOrder>();
                EDIOrder ord = SetUpNewOrder();

                foreach (String line in lines)
                {
                    String[] nodes = line.Split('*');
                    switch (nodes[0])
                    {
                        case "BEG":
                            ProcessBEG(nodes, ord);
                            break;
                        case "REF":
                            ProcessREF(nodes, ord);
                            break;
                        case "N1":
                            ProcessN1(nodes, ord);
                            break;
                        case "N2":
                            ProcessN2(nodes, ord);
                            break;
                        case "N3":
                            ProcessN3(nodes, ord);
                            break;
                        case "N4":
                            ProcessN4(nodes, ord);
                            break;
                        case "PO1":
                            ProcessPO1(nodes, ord);
                            break;
                        case "SE":
                            listOrder.Add(ord);
                            ord.message = "PO: " + ord.purchaseOrder + " - CustPO: " + ord.customerPurchaseOrder + " ready to send";
                            ord = SetUpNewOrder();
                            break;
                        default:
                            break;
                    }
                    lineNumber += 1;
                }

                return listOrder;
            }
            catch (Exception ex)
            {
                DLog.Log(ex.ToString(), DLog.LogLevel.Error, DotConst.SENDEMAIL);
                return null;
            }
        }


        private List<WSOrder.SalesOrder> ProcessOrders(List<EDIOrder> listOrders, SessionInfo si)
        {
            List<WSOrder.SalesOrder> listProcessedOrders = new List<WSOrder.SalesOrder>();

            try
            {
                foreach (EDIOrder ord in listOrders)
                {
                    try
                    {
                        using (var client = new WSOrder.DotitOrdersSoapClient("DotitOrdersSoap"))
                        {
                            WSOrder.SalesOrder so = new WSOrder.SalesOrder();

                            so.sessionGUID = si.sessionGuid;
                            so.customerId = ord.customerId;
                            so.orderType = ord.orderType;
                            so.needByDate = DateTime.Now.AddDays(4);
                            so.poNumber = ord.purchaseOrder;
                            so.customerPONumber = ord.customerPurchaseOrder ?? "";
                            so.orderCast = WSOrder.OrderCast.LinesOnly;
                            DotItShipping dis = new DotItShipping();
                            so.requestDate = dis.NextShippingDate(1);
                            so.useRequestDate = true;
                            so.shipToNumber = ord.shipToNumber;
                            so.shipVia = ord.shipMethod ?? "";
                            so.isOrderHeld = ord.isOrderHeld;
                            so.shipToOneTime = ord.shipToOneTime;
                            so.isShipOrderComplete = ord.isShipOrderComplete;
                            so.addressShipTo = new WSOrder.Address();
                            so.addressShipTo.city = ord.shipTo.city;
                            so.addressShipTo.company = ord.shipTo.company;
                            so.addressShipTo.contactEmail = ord.shipTo.contactEmail;
                            so.addressShipTo.contactFax = ord.shipTo.contactFax;
                            so.addressShipTo.contactName = ord.shipTo.contactName;
                            so.addressShipTo.contactPhoneNum = ord.shipTo.contactPhone;
                            so.addressShipTo.country = ord.shipTo.country;
                            so.addressShipTo.line1 = ord.shipTo.addrLine1;
                            so.addressShipTo.state = ord.shipTo.state;
                            so.addressShipTo.zip = ord.shipTo.zip;
                            so.customerPONumber = ord.reference.customerPONumber;

                            List<WSOrder.SalesOrderLineItem> listSOLI = new List<WSOrder.SalesOrderLineItem>();

                            foreach (PO1 po1 in ord.listPO1)
                            {
                                WSOrder.SalesOrderLineItem soli = new WSOrder.SalesOrderLineItem();
                                soli.submittedPartNumber = po1.productId;
                                soli.submittedQuantity = Convert.ToDecimal(po1.quantityOrdered);
                                soli.submittedUOM = po1.uom;
                                soli.submittedUnitPrice = po1.unitPrice;

                                listSOLI.Add(soli);
                            }

                            so.listLineItems = listSOLI.ToArray();

                            //  Set timeout to 15 minutes for larger orders - default is 1 minute
                            client.InnerChannel.OperationTimeout = new TimeSpan(0, 15, 0);
                            WSOrder.SalesOrder soResult = client.CreateSalesOrder(si.sessionGuid, so);

                            foreach (WSOrder.SalesOrderLineItem soli in soResult.listInvalidLineItems)
                            {
                                ord.e10OrderMessage += soli.returnMessage + Environment.NewLine;
                            }
                            ord.e10OrderMessage += "PO: " + so.poNumber + " - " + soResult.dsr.returnMessage + Environment.NewLine;

                            DLog.Log(soResult.dsr.returnMessage);

                            listProcessedOrders.Add(soResult);
                        }
                    }
                    catch (Exception ex)
                    {
                        DLog.Log("Purchase Order: " + ord.purchaseOrder + " had the following issues: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                String svn = ex.Message;
                throw;
            }

            DLog.Log("");
            DLog.Log("Order Processing Complete");
            DLog.Log("");

            return listProcessedOrders;
        }


        private EDIOrder SetUpNewOrder()
        {
            EDIOrder ord = new EDIOrder();
            ord.customerId = DataStructures.GetAppConfigSetting("e10CustomerId", "EDISubmit", DLog.isTest);
            ord.shipToOneTime = true;
            ord.isCreditCardOrder = false;
            ord.isOrderHeld = false;
            ord.isShipOrderComplete = true;
            ord.orderType = "EDI";
            ord.shipMethod = "UPC";
            return ord;
        }


        public static SessionInfo EstablishSession()
        {
            SessionInfo si = new SessionInfo();

            try
            {
                using (var client = new WSPartner.DotitPartnerSoapClient("DotitPartnerSoap"))
                {
                    WSPartner.DotitCredentials cred = new WSPartner.DotitCredentials();
                    cred.userId = DataStructures.GetAppConfigSetting("userId", "EDISubmit", DLog.isTest);
                    cred.password = DataStructures.GetAppConfigSetting("password", "EDISubmit", DLog.isTest);
                    cred.partnerId = Convert.ToInt32(DataStructures.GetAppConfigSetting("partnerId", "EDISubmit", DLog.isTest));

                    Int32 activeSeconds = Convert.ToInt32(DataStructures.GetAppConfigSetting("sessionActiveSeconds", "E10BLL", DLog.isTest));

                    DLog.Log("sessionActiveSecond: " + activeSeconds);
                    if (activeSeconds > 1200)
                    {
                        activeSeconds = 1200;
                        DLog.Log("sessionActiveSecond: " + activeSeconds);
                    }

                    WSPartner.CreateSessionResponse csr = client.CreateAccountUserSession(cred, 480);

                    si.result = csr.dsr.success;

                    if (csr.dsr.success)
                    {
                        si.resultMessage = "Successfully established session!";
                        si.sessionGuid = csr.dsr.returnMessage;
                    }
                    else
                    {
                        si.resultMessage = "Unsuccessfully established session!";
                    }
                }
            }
            catch (Exception ex)
            {
                si.resultMessage = "Establish Session abended with: " + ex.ToString();
                DLog.Log(si.resultMessage, DLog.LogLevel.Error, DotConst.SENDEMAIL);
            }

            return si;
        }


        private EDIOrder ProcessBEG(String[] nodes, EDIOrder ord)
        {
            ord.beg.transactionSetPurposeCode = nodes[1];
            ord.beg.pucrhaseOrderTypeCode = nodes[2];
            ord.purchaseOrder = nodes[3];
            ord.beg.date = Convert.ToDateTime(nodes[5].Substring(4, 2) + "/" + nodes[5].Substring(6, 2) + "/" + nodes[5].Substring(0, 4), CultureInfo.CurrentCulture);
            return ord;
        }


        private EDIOrder ProcessREF(String[] nodes, EDIOrder ord)
        {
            ord.reference.refType = nodes[1];
            ord.reference.customerPONumber = nodes[2];
            return ord;
        }


        private EDIOrder ProcessN1(String[] nodes, EDIOrder ord)
        {
            N1 n1 = new N1();
            n1.EntityIdentiferCode = nodes[1];
            n1.Name = nodes[2];
            if (nodes.Length >= 4)
            {
                n1.IdentificationCodeQualifer = nodes[3];
                if (nodes.Length >= 5)
                {
                    n1.IdentificationCode = nodes[4];
                }
            }

            if (n1.EntityIdentiferCode == "SF") isShipFrom = true;
            if (n1.EntityIdentiferCode == "ST") isShipTo = true;

            if (isShipFrom)
            {
                ord.shipFrom.shippingId = n1.IdentificationCode;
                ord.shipFrom.company = n1.Name;
            }

            if (isShipTo)
            {
                ord.shipToNumber = n1.IdentificationCode;
                ord.shipTo.company = n1.Name;
            }

            return ord;
        }


        private EDIOrder ProcessN2(String[] nodes, EDIOrder ord)
        {
            if (isShipFrom)
            {
            }

            if (isShipTo)
            {
            }

            return ord;
        }


        private EDIOrder ProcessN3(String[] nodes, EDIOrder ord)
        {
            N3 n3 = new N3();
            n3.address = nodes[1];

            if (isShipFrom)
            {
                ord.shipFrom.addrLine1 = n3.address;
            }

            if (isShipTo)
            {
                ord.shipTo.addrLine1 = n3.address;
            }

            return ord;
        }


        private EDIOrder ProcessN4(String[] nodes, EDIOrder ord)
        {
            N4 n4 = new N4();
            n4.city = nodes[1];
            n4.state = nodes[2];
            n4.zip = nodes[3];

            if (isShipFrom)
            {
                ord.shipFrom.city = n4.city;
                ord.shipFrom.state = n4.state;
                ord.shipFrom.zip = n4.zip;
            }

            if (isShipTo)
            {
                ord.shipTo.city = n4.city;
                ord.shipTo.state = n4.state;
                ord.shipTo.zip = n4.zip;
                ord.shipTo.contactName = DataStructures.GetAppConfigSetting("NCCOContact", "E10BLL", DLog.isTest);
                ord.shipTo.contactPhone = DataStructures.GetAppConfigSetting("NCCOContactPhone", "E10BLL", DLog.isTest);
                ord.shipTo.contactEmail = DataStructures.GetAppConfigSetting("NCCOContactEmail", "E10BLL", DLog.isTest);
            }

            isShipFrom = false;
            isShipTo = false;

            return ord;
        }


        private EDIOrder ProcessPO1(String[] nodes, EDIOrder ord)
        {
            PO1 po1 = new PO1();
            po1.assignedIdentification = nodes[1];
            po1.quantityOrdered = Convert.ToDouble(nodes[2]);
            po1.uom = nodes[3];
            po1.productIdQualifer = nodes[6];
            po1.productId = nodes[7];

            if (po1.quantityOrdered < 1)
            {
                String msg = "Order: " + ord.purchaseOrder + " line item: " + po1.assignedIdentification + " part number: " + po1.productId + " has a quantity of 0 (zero)";
                DLog.Log(msg + "   : qty node : " + nodes[2], DLog.LogLevel.Error, true, null, "", "agarza@dotit.com;nickn@nationalchecking.com;jen@nationalchecking.com;svanniman@dotit.com");
            }
            else
            {
                DLog.Log("Adding part: " + po1.productId + " to order: " + ord.purchaseOrder);
                ord.listPO1.Add(po1);
            }

            return ord;
        }


        public class EDIOrder
        {
            public ADDRESS shipFrom { get; set; }
            public ADDRESS shipTo { get; set; }
            public ADDRESS billTo { get; set; }
            public Boolean shipToOneTime { get; set; }
            public Boolean isOrderHeld { get; set; }
            public Boolean isShipOrderComplete { get; set; }
            public Boolean isCreditCardOrder { get; set; }
            public Boolean hasReleases { get; set; }
            public String orderType { get; set; }
            public String purchaseOrder { get; set; }
            public String customerPurchaseOrder { get; set; }
            public String shipToNumber { get; set; }
            public String shipMethod { get; set; }
            public String message { get; set; }
            //  Unique number assigned to the customer (not the primary identity key of the customer table)
            public String customerId { get; set; }
            public DateTime orderDate { get; set; }
            public DateTime needByDate { get; set; }
            //public ST st { get; set; }
            public BEG beg { get; set; }
            public REF reference { get; set; }
            //public SE se { get; set; }
            //public CTT ctt { get; set; }
            //public DTM dtm { get; set; }
            //public FOB fob { get; set; }
            //public List<REF> listREF { get; set; }
            public List<PO1> listPO1 { get; set; }
            //public List<PID> listPID { get; set; }
            public String e10OrderNumber = "";
            public String e10OrderMessage = "";
            public String e10OrderWarningMessage = "";


            public EDIOrder()
            {
                shipToOneTime = true;
                isOrderHeld = false;
                isShipOrderComplete = true;
                isCreditCardOrder = false;
                shipToOneTime = true;
                purchaseOrder = "";
                customerPurchaseOrder = "";
                shipToNumber = "";
                shipMethod = "UPC";
                customerId = "";
                orderType = "Online";
                shipFrom = new ADDRESS();
                shipTo = new ADDRESS();
                billTo = new ADDRESS();
                //st = new ST();
                beg = new BEG();
                reference = new REF();
                //se = new SE();
                //ctt = new CTT();
                //dtm = new DTM();
                //fob = new FOB();
                //listREF = new List<REF>();
                listPO1 = new List<PO1>();
                //listPID = new List<PID>();
            }
        }


    public class ADDRESS
    {
        private String _contactName;

        public String shippingId { get; set; }
        public String company { get; set; }
        public String addrLine1 { get; set; }
        public String addrLine2 { get; set; }
        public String addrLine3 { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String country { get; set; }
        public String contactName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_contactName))
                {
                    return (contactFirstName + " " + contactLastName).Trim();
                }
                else
                {
                    return _contactName;
                }
            }

            set { _contactName = value; }
        }
        public String contactEmail { get; set; }
        public String contactPhone { get; set; }
        public String contactFax { get; set; }
        public String contactFirstName { get; set; }
        public String contactLastName { get; set; }

        public ADDRESS()
        {
            shippingId = "";
            company = "";
            addrLine1 = "";
            addrLine2 = "";
            addrLine3 = "";
            city = "";
            state = "";
            zip = "";
            country = "USA";
            contactName = "";
            contactEmail = "";
            contactPhone = "";
            contactFax = "";
        }
    }


    public class BEG
    {
        public String transactionSetPurposeCode { get; set; }
        public String pucrhaseOrderTypeCode { get; set; }
        public String purchaseOrderNumber { get; set; }
        public DateTime date { get; set; }
    }


    public class REF
    {
        public String refType { get; set; }
        public String customerPONumber { get; set; }
    }


    public class N1
        {
            private String entityIdentiferCode = "";
            private String name = "";
            private String identificationCodeQualifer = "";
            private String identificationCode = "";

            public String EntityIdentiferCode
            {
                get { return entityIdentiferCode; }
                set { entityIdentiferCode = value; }
            }

            public String Name
            {
                get { return name; }
                set { name = value; }
            }

            public String IdentificationCodeQualifer
            {
                get { return identificationCodeQualifer; }
                set { identificationCodeQualifer = value; }
            }

            public String IdentificationCode
            {
                get { return identificationCode; }
                set { identificationCode = value; }
            }
        }


        public class N3
        {
            public String address { get; set; }
        }


        public class N4
        {
            public String city { get; set; }
            public String state { get; set; }
            public String zip { get; set; }

            public N4()
            {
                city = "";
                state = "";
                zip = "";
            }
        }


        public class PO1
        {
            public String assignedIdentification { get; set; }
            public Double quantityOrdered { get; set; }
            public String uom { get; set; }
            public Decimal unitPrice { get; set; }
            public String productIdQualifer { get; set; }
            public String productId { get; set; }
            public String productDescription { get; set; }

            public PO1()
            {
                assignedIdentification = "";
                quantityOrdered = 0;
                uom = "";
                unitPrice = 0.0M;
                productIdQualifer = "";
                productId = "";
                productDescription = "";
            }
        }


        public static void OrderNotification(List<WSOrder.SalesOrder> listOrders, String notifyEmails = "svanniman@dotit.com", String salutation = "Dear CSR's")
        {
            DLog.StartModule("OrderNotification");

            String emailBody = "";
            Boolean anyIssues = false;
            Boolean anyWarnings = false;
            String orderOutput = "";
            String c = ":";

            if (listOrders[0].dsr.returnMessage.Length > 16 && listOrders[0].dsr.returnMessage.Substring(0, 16) == "Version mismatch")
            {
                notifyEmails = "svanniman@dotit.com";
            }

            DLog.Log("There are " + listOrders.Count.ToString() + " order(s) to be included in the email notification");
            if (DLog.isTest) orderOutput += "<p><font color = 'blue'>This order has been processed against the TEST version of Epicor</font></p>";

            foreach (WSOrder.SalesOrder so in listOrders)
            {
                DLog.Log("Results: " + so.dsr.returnCode.ToString() + " : " + so.dsr.returnMessage);
                foreach (WSOrder.DLogMessage m in so.dsr.listMessages)
                {
                    if (m.messageType == WSOrder.LogLevel.Warn) anyWarnings = true;
                    DLog.Log(m.messageType.ToString() + " : " + m.message);
                    if (m.messageType == WSOrder.LogLevel.Info) orderOutput += "<p>" + m.message + "</p>";
                }

                if (!so.dsr.success)
                {
                    anyIssues = true;

                    foreach (WSOrder.SalesOrderLineItem sol in so.listInvalidLineItems)
                    {
                        orderOutput += "<p><font color = 'red'>" + sol.returnMessage + "</font></p>";
                    }

                    orderOutput += "<p>" + so.dsr.returnMessage + "</p>";
                }
                else
                {
                    orderOutput += "  " + so.dsr.returnMessage + "<br />";
                }
            }

            if (anyIssues)
            {
                emailBody += "<p><font color='red'>**********************   Attention there was an issue with one or more orders.  Details below.    *********************</font></p>";
            }
            if (anyWarnings)
            {
                emailBody += "<p><font color='blue'>++ denotes discrepancies</font></p>";
            }

            DLog.Log("Ready to produce body of email:");

            String emailTitle = "Dot It Submit Orders processed " + listOrders.Count.ToString() + " order(s)";

            String separator = "<p>===========================================================</p>";
            String trs = "<tr><td>";
            String tre = "</td></tr>";
            String tdb = "</td><td>";

            emailBody += "<p>" + emailTitle + "</p>" + separator;

            emailBody += orderOutput;

            emailBody += "<p>===========================================================</p>";

            foreach (WSOrder.SalesOrder order in listOrders)
            {
                emailBody += "<Table cellpadding='4' style='font-family:arial;font-size:12;'>";
                emailBody += trs + "<div style='width:120;'>Order Type:            </div>" + tdb + order.orderType + tre;
                emailBody += trs + "Epicor Return Message: " + tdb + order.dsr.returnMessage + tre;
                emailBody += trs + "Customer Id:           " + tdb + order.customerId + tre;
                emailBody += trs + "Purchase Order:        " + tdb + order.poNumber + tre;
                emailBody += trs + "Customer PO Num:       " + tdb + order.customerPONumber + tre;
                emailBody += trs + "Need by Date:          " + tdb + order.needByDate + tre;
                emailBody += trs + "CC Order:              " + tdb + order.isCreditCardOrder.ToString() + tre;
                emailBody += trs + "Order to be Held:      " + tdb + order.isOrderHeld.ToString() + tre;
                emailBody += trs + "Order Ship Complete:   " + tdb + order.isShipOrderComplete.ToString() + tre;
                emailBody += trs + "Shipping Method:       " + tdb + order.shipVia + tre;
                emailBody += trs + "Ship to One time ship: " + tdb + order.shipToOneTime.ToString() + tre;
                emailBody += trs + "Ship to Number:        " + tdb + order.shipToNumber + tre;
                emailBody += trs + "Ship to Company:       " + tdb + order.addressShipTo.company + tre;
                emailBody += trs + "Ship to Name:          " + tdb + order.addressShipTo.contactName + tre;
                emailBody += trs + "Ship to Email:         " + tdb + order.addressShipTo.contactEmail + tre;
                emailBody += trs + "Ship to Phone:         " + tdb + order.addressShipTo.contactPhoneNum + tre;
                emailBody += trs + "Ship to Fax:           " + tdb + order.addressShipTo.contactFax + tre;
                emailBody += trs + "Ship to Address1:      " + tdb + order.addressShipTo.line1 + tre;
                emailBody += trs + "Ship to Address2:      " + tdb + order.addressShipTo.line2 + tre;
                emailBody += trs + "Ship to City:          " + tdb + order.addressShipTo.city + tre;
                emailBody += trs + "Ship to State:         " + tdb + order.addressShipTo.state + tre;
                emailBody += trs + "Ship to Zip:           " + tdb + order.addressShipTo.zip + tre;
                emailBody += trs + "Ship to Country:       " + tdb + order.addressShipTo.country;
                emailBody += "</Table>";

                emailBody += "<p>---------------------------------------------------------</p>";

                foreach (String caseOrder in order.listCasedOrders)
                {
                    emailBody += "<font size='2'>" + caseOrder + "</font></br>";
                }

                emailBody += "</br></br><Table cellpadding='4' style='font-family:arial;font-size:12;'>";
                emailBody += trs + "Line" + tdb + "Part/Sku" + tdb + "Qty" + tdb + "Unit Price" + tdb + "UOM" + tdb + "Parts per Case" + tre;


                foreach (WSOrder.SalesOrderLineItem li in order.listLineItems)
                {
                    String discrepancyUOM = "";
                    String discrepancyUnitPrice = "";
                    String partsPerContainer = "";

                    if (!String.IsNullOrWhiteSpace(li.submittedUOM) && li.returnedUOM != li.submittedUOM)
                    {
                        discrepancyUOM = "<font color='blue'>  ++ (" + li.submittedUOM + ")</font>";
                    }
                    if (li.submittedUnitPrice > 0.0m && li.returnedUnitPrice != li.submittedUnitPrice)
                    {
                        discrepancyUnitPrice = "<font color='blue'>  ++ (" + li.submittedUnitPrice.ToString("#,##0.00") + ")</font>";
                    }
                    if (li.partsPerContainer > 0)
                    {
                        partsPerContainer = li.partsPerContainer.ToString();
                    }

                    emailBody += trs + li.lineItemNumber + tdb + li.returnedPartNumber + tdb + li.returnedQuantity + tdb + li.returnedUnitPrice.ToString("#,##0.00")
                        + discrepancyUnitPrice + tdb + li.returnedUOM + discrepancyUOM + tdb + partsPerContainer + tre;

                    foreach (WSOrder.SalesOrderRelease sor in li.listSalesOrderReleases)
                    {
                        if (sor.release == "null") sor.release = "<font color='red'>" + sor.release + "</font>";
                        String sentTo = sor.shipTo.company + c + sor.shipTo.contactName + c + sor.shipTo.line1 + c + sor.shipTo.city + c + sor.shipTo.state + c + sor.shipTo.zip;
                        emailBody += "<tr><td colspan='8'>Release: " + sor.release + " Qty: " + sor.orderQty + " to: " + sentTo + "</td></tr>";
                    }
                }

                emailBody += "</Table>" + separator;

            }

            DLog.Log("Done with body: -- isTest: " + DLog.isTest.ToString());

            emailBody += "<p>End Order Submission</p>";

            String orderNotifyEmails = DataStructures.GetAppConfigSetting("EDINotifyEmails", "EDISubmit", DLog.isTest);

            //DLog.Log("Sending notification to1: " + orderNotifyEmails);

            //if (!String.IsNullOrWhiteSpace(notifyEmails)) orderNotifyEmails = notifyEmails;

            DLog.Log("Sending notification to2: " + orderNotifyEmails);

            DEmail.SendEmailNotification(emailBody, emailTitle, salutation, orderNotifyEmails);

            String fileName = DataStructures.GetAppConfigSetting("NCCOEDIFilePath", "E10bll", DLog.isTest) + @"History\notification-" + DateTime.Now.ToString("yy-MM-dd-hh-mm") + ".html";
            File.WriteAllText(fileName, emailBody);

            DLog.Log("email sent");

            DLog.EndModule("OrderNotification");

        }


    }
}
