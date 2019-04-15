using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Erp.BO;
using Erp.Proxy.BO;
using Ice.Core;
using Ice.Lib.Framework;


using DotCommon;
using DotitBllDal;
using EpicorDaily.Model;

namespace EpicorDaily
{
    class PunchhSwag
    {
        #region//20190405- Amit : Property declare to call Epicor Api Caller 
        public static EpicorBusinessApi _EpicorBusinessApi { get; set; }
        #endregion
        public static void CheckSWAGOrders(Session session)
        {
            DLog.StartModule();


            CreateSWAGE10SalesOrder(session);

            GenerateRates(session);

            GenerateShipping(session);

            CloseOutSwagOrders(session);
        }


        public static void CreateSWAGE10SalesOrder(Session session)
        {
            DLog.StartModule();

            //  Customer for Freebirds App Swag
            String swagCustId = "95164";

            DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);
            // EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

            var rsNewSwagOrders = from p in ds.PUNCHHSWAGs where p.DELVALIDATED && p.E10ORDERNUMBER == 0 select p;

            if (rsNewSwagOrders.Count() <= 0)
            {
                DLog.Log("Nothing to process at this time: " + rsNewSwagOrders.Count());
                return;
            }

            DLog.Log("New Swag Orders to be processed: " + rsNewSwagOrders.Count());

            foreach (PUNCHHSWAG swag in rsNewSwagOrders)
            {
                String poNum = "FB AppSwag " + swag.FBREDEMPTIONCODE;

                #region ErrorChecking

                if (GetOrderHeadsContainsPONum(poNum))
                {
                    DLog.Log("Duplicate PO Number on a SWAG code: " + swag.FBREDEMPTIONCODE, DLog.LogLevel.Error, true);
                    continue;
                }

                #endregion

                Boolean isContinue = false;
                String responseMessage;
                String creditShipAction;
                String displayMessage;
                String compliantMessage;
                String responseMsgOrdRel;
                String cCreditLimitMessage;
                String cAgingMessage;
                Int32 iOrderNum = 0;

                try
                {
                    using (var salesOrderBO = WCFServiceSupport.CreateImpl<SalesOrderImpl>(session, SalesOrderImpl.UriPath))
                    {
                        SalesOrderDataSet salesOrderDS = new SalesOrderDataSet();
                        salesOrderBO.GetNewOrderHed(salesOrderDS);
                        SalesOrderDataSet.OrderHedRow orderHedRow = salesOrderDS.OrderHed[salesOrderDS.OrderHed.Count - 1];
                        Boolean lCheckForOrderChangedMsg = false;
                        Boolean lcheckForResponse = false;
                        salesOrderBO.OnChangeofSoldToCreditCheck(iOrderNum, swagCustId, out cCreditLimitMessage, out cAgingMessage, out isContinue, salesOrderDS);

                        salesOrderBO.ChangeSoldToID(salesOrderDS);
                        salesOrderBO.ChangeCustomer(salesOrderDS);
                        orderHedRow["orderType_c"] = "Email";
                        orderHedRow.PONum = poNum;

                        DotItShipping dis = new DotItShipping();
                        orderHedRow.RequestDate = dis.NextShippingDate(26);
                        orderHedRow.NeedByDate = orderHedRow.RequestDate.AddDays(5);

                        orderHedRow.OrderHeld = false;
                        orderHedRow.ShipOrderComplete = true;
                        orderHedRow.CreditCardOrder = false;
                        salesOrderBO.ChangeNeedByDate(salesOrderDS, "OrderHed");

                        salesOrderBO.ChangeHedUseOTS(salesOrderDS);

                        lCheckForOrderChangedMsg = true;
                        lcheckForResponse = true;

                        orderHedRow.OTSCntryDescription = swag.DELCOUNTRY;
                        orderHedRow.UseOTS = true;
                        orderHedRow.OTSName = swag.DELNAME;
                        orderHedRow.OTSAddress1 = swag.DELADDR;
                        orderHedRow.OTSCity = swag.DELCITY;
                        orderHedRow.OTSState = swag.DELSTATE;
                        orderHedRow.OTSZIP = swag.DELPOSTAL;
                        orderHedRow.OTSContact = swag.DELATTN;
                        orderHedRow.OTSPhoneNum = swag.DELPHONE;
                        orderHedRow.NotifyEMail = swag.DELEMAIL;
                        orderHedRow.ResDelivery = swag.ISRESIDENTIAL;

                        //  TODO - need to incorporate Canada
                        orderHedRow.OTSCountryNum = 205;

                        orderHedRow.CurrencySwitch = false;
                        orderHedRow.OTSTaxRegionCode = "NTS";
                        orderHedRow.ShipToAddressList = "  ~USA";
                        orderHedRow.TaxRegionCodeDescription = "Non-Taxable State";

                        salesOrderBO.ChangeHedOTSCountryNum(salesOrderDS);

                        //  Have to move this here as a ChangeShipToID will blank out the field.
                        if (!String.IsNullOrWhiteSpace(poNum)) orderHedRow.ServRef2 = poNum;
                        orderHedRow.ShipViaCode = swag.SHIPVIA;

                        salesOrderBO.MasterUpdate(lCheckForOrderChangedMsg, lcheckForResponse, "OrderHed", orderHedRow.CustNum, orderHedRow.OrderNum, false,
                            out isContinue, out responseMessage, out creditShipAction, out displayMessage, out compliantMessage, out responseMsgOrdRel, out cAgingMessage, salesOrderDS);

                        String[] parts = swag.DOTITPART.Split('|');

                        foreach (String part in parts)
                        {
                            Guid sysRowId = new Guid();
                            String partNumber = part;
                            String uomCode = "";
                            String rowType = "";
                            String deleteComponentsMessage = "";
                            String questionString = "";
                            String warningMessage = "";
                            String configPartMessage = "";
                            String subPartMessage = "";
                            String explodeBOMerrMessage = "";
                            String messageType = "";
                            String pcMessage = "";
                            String pcNeqQtyAction = "";
                            String OpWarningMsg = "";
                            String cSellingQuantityChangedMsgText = "";

                            Boolean isSubstitutePartExist = new Boolean();
                            Boolean isPhantom = new Boolean();
                            Boolean isSalesKitView = new Boolean();
                            Boolean removeKitComponents = new Boolean();
                            Boolean suppressUserPrompts = new Boolean();
                            Boolean getPartXRefInfo = new Boolean();
                            Boolean checkPartRevisionChange = new Boolean();
                            Boolean checkChangeKitParent = new Boolean();
                            Boolean isMultipleMatch = new Boolean();
                            Boolean isPromptToExplodeBOM = new Boolean();
                            Boolean isMultiSubsAvail = new Boolean();
                            Boolean isRunOutQtyAvail = new Boolean();


                            salesOrderBO.GetNewOrderDtl(salesOrderDS, orderHedRow.OrderNum);
                            SalesOrderDataSet.OrderDtlRow orderDtlRow = salesOrderDS.OrderDtl[salesOrderDS.OrderDtl.Count - 1];

                            orderDtlRow["ShipBoxNumber_c"] = 1;
                            orderDtlRow.RequestDate = orderHedRow.RequestDate;
                            orderDtlRow.NeedByDate = orderHedRow.NeedByDate;

                            salesOrderBO.ChangePartNumMaster(ref partNumber, ref isSubstitutePartExist, ref isPhantom, ref uomCode, sysRowId, rowType, isSalesKitView, removeKitComponents,
                                suppressUserPrompts, getPartXRefInfo, checkPartRevisionChange, checkChangeKitParent, out deleteComponentsMessage, out questionString,
                                out warningMessage, out isMultipleMatch, out isPromptToExplodeBOM, out configPartMessage, out subPartMessage, out explodeBOMerrMessage, out messageType,
                                out isMultiSubsAvail, out isRunOutQtyAvail, salesOrderDS);
                            salesOrderBO.ChangeSellingQtyMaster(salesOrderDS, 1, false, false, true, true, true, true,
                                part, "", "", "", uomCode, 1, out pcMessage, out pcNeqQtyAction, out OpWarningMsg, out cSellingQuantityChangedMsgText);

                            salesOrderBO.MasterUpdate(true, true, "OrderDtl", orderHedRow.CustNum, orderHedRow.OrderNum, false, out isContinue, out responseMessage, out creditShipAction,
                                out displayMessage, out compliantMessage, out responseMsgOrdRel, out cAgingMessage, salesOrderDS);

                        }

                        PUNCHHSWAG swagUpdate = (from ps in ds.PUNCHHSWAGs where ps.FBREDEMPTIONCODE == swag.FBREDEMPTIONCODE select ps).Single();
                        swagUpdate.E10ORDERNUMBER = orderHedRow.OrderNum;
                        ds.SubmitChanges();

                        SalesOrderE10.UpdateMiscFeeByOrder(session, orderHedRow.OrderNum, 1.5m, DataStructures.OrderMiscType.Kitting);

                        DLog.Log("Swag code: " + swagUpdate.FBREDEMPTIONCODE + " created Epicor order: " + swagUpdate.E10ORDERNUMBER);
                    }
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex, "Swag Redemption Code: " + swag.FBREDEMPTIONCODE, true);
                }
            }
        }


        private static void GenerateRates(Session session)
        {
            DLog.StartModule();

            DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

            var rsSwagNeedingRates = from p in ds.PUNCHHSWAGs
                                     where p.E10ORDERNUMBER != 0 && p.DELVALIDATED && p.TRACKINGNUMBER == ""
                                     && (p.SHIPVIA.ToUpper() == "SPG1" || p.SHIPVIA.ToUpper() == "SPL1") && (p.OURRATE == 0.0m || p.PUBLICRATE == 0.0m)
                                     select p;

            if (rsSwagNeedingRates.Count() <= 0)
            {
                DLog.Log("There is nothing to do for GenerateRates at this time.");
                return;
            }

            DLog.Log("There are " + rsSwagNeedingRates.Count() + " orders needing rates.");

            foreach (PUNCHHSWAG swag in rsSwagNeedingRates)
            {
                try
                {
                    DataStructures.Package pack = ShippingE10.CreatePackage(swag.E10ORDERNUMBER, 1, swag.WEIGHT);
                    DataStructures.Package finishedPack = UPS.Rate.ReturnRate(pack);

                    if (finishedPack.publicRate > 0.0m && finishedPack.negotiatedRate > 0.0m)
                    {
                        swag.OURRATE = finishedPack.negotiatedRate;
                        swag.PUBLICRATE = finishedPack.publicRate;

                        Boolean addFreight = SalesOrderE10.UpdateMiscFeeByOrder(session, swag.E10ORDERNUMBER, swag.PUBLICRATE, DataStructures.OrderMiscType.Freight);

                        if (!addFreight)
                        {
                            String body = "Issues adding freight to order: " + swag.E10ORDERNUMBER + " please check logs";
                            DEmail.SendEmailNotification(body, "Swag Generate Rates", "Yo", "svanniman@dotit.com");
                        }
                    }
                }
                catch (Exception ex)
                {
                    DLog.Log("Issues with Redemption Code: " + swag.FBREDEMPTIONCODE + " ex: " + ex.Message, DLog.LogLevel.Error, true);
                }
            }

            ds.SubmitChanges();
        }


        private static void GenerateShipping(Session session)
        {
            DLog.StartModule();

            DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

            var rsSwagGenerateShipping = from p in ds.PUNCHHSWAGs
                                         where p.E10ORDERNUMBER != 0 && p.DELVALIDATED && p.TRACKINGNUMBER == ""
                                         select p;

            if (rsSwagGenerateShipping.Count() <= 0)
            {
                DLog.Log("There is nothing to do for GenerateShipping at this time.");
                return;
            }

            DLog.Log("There are " + rsSwagGenerateShipping.Count() + " orders needing shipping generated.");

            String subFolder = DataStructures.GetAppConfigSetting("swagLabelPath", "Mops");

            foreach (PUNCHHSWAG swag in rsSwagGenerateShipping)
            {
                try
                {
                    var rsPX = from p in ds.PARTXREFs where p.PARTNUM == swag.DOTITPART select p.FOLDER;

                    if (rsPX.Count() == 0)
                    {
                        DLog.Log("No cross reference part found for: " + swag.DOTITPART, DLog.LogLevel.Error, true);
                        continue;
                    }

                    String pX = rsPX.First();

                    if (swag.SHIPVIA.ToUpper() == "FC")
                    {
                        if (!GenerateShippingUSPS(ds, swag, subFolder, pX, session)) return;
                        SalesOrderE10.UpdateMiscFeeByOrder(session, swag.E10ORDERNUMBER, swag.PUBLICRATE, DataStructures.OrderMiscType.Freight);
                    }
                    else
                    {
                        DataStructures.Package pack = ShippingE10.CreatePackage(swag.E10ORDERNUMBER, 1, swag.WEIGHT, swag.ISRESIDENTIAL);
                        GenerateShippingUPS(ds, swag, subFolder, pack, pX);
                    }

                }
                catch (Exception ex)
                {
                    DLog.Log("Issues with Redemption Code: " + swag.FBREDEMPTIONCODE + " ex: " + ex.Message, DLog.LogLevel.Error, true);
                }
            }

            ds.SubmitChanges();
        }


        private static Boolean GenerateShippingUSPS(DotitExtDataContext ds, PUNCHHSWAG swag, String subfolder, String pX, Session session)
        {
            DLog.StartModule();

            try
            {
                EndiciaAPI.EndiciaGenerateLabelRequest eglr = new EndiciaAPI.EndiciaGenerateLabelRequest("FREEB!RDS Swag");
                eglr.SetSwagAddress(swag);
                eglr.fullLabelFileName = subfolder + pX + "-o" + swag.E10ORDERNUMBER + ".epl";
                eglr.isTest = "NO";
                eglr.shipVia = swag.SHIPVIA;
                eglr.partnerCustomerId = "95164";
                eglr.partnerTransactionId = swag.E10ORDERNUMBER.ToString();
                eglr.weightLBS = swag.WEIGHT;

                EndiciaAPI.EndiciaGenerateLabelResponse eglRSP = EndiciaAPI.GenerateUSPSLabel(eglr);
                if (!eglRSP.dsr.success)
                {
                    return false;
                }

                swag.TRACKINGNUMBER = eglRSP.trackingNumber;
                swag.OURRATE = eglRSP.postage;
                swag.PUBLICRATE = eglRSP.postage;
                swag.ENDICIATRANSID = eglRSP.transactionId;
                ds.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
                return false;
            }
        }


        private static Boolean GenerateShippingUPS(DotitExtDataContext ds, PUNCHHSWAG swag, String subfolder, DataStructures.Package pack, String pX)
        {
            DLog.StartModule();

            try
            {
                DataStructures.Package finishedPack = UPS.Ship.ShipPackage(pack, subfolder, pX + "-o" + swag.E10ORDERNUMBER);

                if (!String.IsNullOrWhiteSpace(finishedPack.trackingNumber))
                {
                    swag.TRACKINGNUMBER = finishedPack.trackingNumber;
                    ds.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
                return false;
            }
        }


        public static void CloseOutSwagOrders(Session session)
        {
            DLog.StartModule();

            DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

            try
            {
                var rsPotential = from ps in ds.PUNCHHSWAGs where ps.E10ORDERNUMBER != 0 && ps.TRACKINGNUMBER != "" && ps.PACKNUM == 0 select ps;

                if (rsPotential.Count() <= 0)
                {
                    DLog.Log("There are no orders to close at this time");
                    return;
                }

                DLog.Log("rsPotential.Count() = " + rsPotential.Count());

                foreach (PUNCHHSWAG swag in rsPotential)
                {
                    try
                    {
                        if (!EnoughInventory(swag.E10ORDERNUMBER))
                        {
                            DLog.Log("There is not enough inventory of part: " + swag.DOTITPART + " to close out code: " + swag.FBREDEMPTIONCODE);
                            continue;
                        }

                        DataStructures.DotitServiceResult dsr = PackoutByOrder(swag.E10ORDERNUMBER, session);
                    }
                    catch (Exception ex)
                    {
                        DLog.LogErr(ex, "Swag redemption code: " + swag.FBREDEMPTIONCODE);
                    }
                }
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
            }
        }


        public static DataStructures.DotitServiceResult PackoutByOrder(Int32 orderId, Session session)
        {
            DLog.StartModule();

            DataStructures.DotitServiceResult dsr = new DotitBllDal.DataStructures.DotitServiceResult();
            using (_EpicorBusinessApi = new EpicorBusinessApi())
            {
                try
                {
                    DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);
                    #region//20190405- Amit : Property declare to call Epicor Api Caller 
                    // EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
                    //=================================================================================
                    //OrderHed orderHed =   (from oh in cs.OrderHeds where oh.OrderNum == orderId select oh).Single();
                    OrderHeadModel orderHed = _EpicorBusinessApi.GetOrderHead().FirstOrDefault(f => f.OrderNum.Equals(orderId));
                    #endregion
                    if (!EnoughInventory(orderHed.OrderNum))
                    {
                        dsr.SetResult(false, -4, "Not enough Inventory for Order: " + orderHed.OrderNum);
                        return dsr;
                    }
                    #region//20190405- Amit : Property declare to call Epicor Api Caller 
                    //var rsShipDtls = from sd in cs.ShipDtls where sd.OrderNum == orderId select sd;
                    var rsShipDtls = _EpicorBusinessApi.GetShipDetail().Where(f => f.OrderNum.Equals(orderId));
                    #endregion
                    if (rsShipDtls.Count() > 0)
                    {
                        Int32 packNum = rsShipDtls.First().PackNum;

                        dsr.SetResult(true, 0, "Skipping - Order: " + orderId.ToString() + " has already been packed out with packnumber from Epicor: " + packNum);

                        PUNCHHSWAG swag = (from p in ds.PUNCHHSWAGs where p.E10ORDERNUMBER == orderId select p).Single();
                        swag.PACKNUM = packNum;
                        ds.SubmitChanges();

                        return dsr;
                    }

                    using (var customerShipBO = WCFServiceSupport.CreateImpl<CustShipImpl>(session, CustShipImpl.UriPath))
                    {
                        String[] outstring = new String[20];
                        Int32[] outint = new Int32[10];
                        Boolean[] outbool = new Boolean[10];

                        var custShipDS = new Erp.BO.CustShipDataSet();
                        customerShipBO.GetNewShipHead(custShipDS);

                        Erp.BO.CustShipDataSet.ShipHeadRow shipHeadRow = custShipDS.ShipHead[custShipDS.ShipHead.Rows.Count - 1];
                        shipHeadRow.CurrencyCode = "USD";

                        customerShipBO.GetHeadOrderInfo(orderId, out outstring[0], custShipDS);

                        customerShipBO.BuildShipToCustomerList(orderId, out outstring[1]);
                        customerShipBO.BuildShipToList(orderId, orderHed.CustNum, out outstring[2]);

                        customerShipBO.UpdateMaster(custShipDS, false, false, false, false, false, false, false, 0, 2, out outstring[0], out outstring[1], out outstring[2], out outstring[3],
                                    out outstring[4], out outstring[5], out outstring[6], out outstring[7], out outstring[8], out outstring[9], out outbool[1],
                                    out outbool[2], out outstring[10], out outstring[11], out outbool[3], out outbool[4], out outbool[5], out outbool[6]);
                        outstring[0] = string.Empty;

                        DLog.Log("First master update in packout with packNum: " + shipHeadRow.PackNum);

                        PackOutDataSet packOutDS = customerShipBO.POGetNew(orderId, shipHeadRow.PackNum, out outstring[1]);
                        packOutDS = customerShipBO.POGetDtlList(shipHeadRow.PackNum, string.Empty, 0, "PACK", out outstring[0]);

                        customerShipBO.PreCreateMassShipDtl(shipHeadRow.PackNum, orderId, out outstring[2], custShipDS);
                        customerShipBO.CreateMassShipDtl(shipHeadRow.PackNum, orderId, custShipDS);


                        //try { customerShipBO.GetManifestInfo(orderId, shipHeadRow.PackNum, custShipDS); } catch (Exception) { }

                        customerShipBO.BuildShipToList(orderId, shipHeadRow.ShipToCustNum, out outstring[0]);
                        customerShipBO.MarkShipmentLines(custShipDS);


                        //  Select bin to pull part

                        for (Int32 i = 0; i < custShipDS.ShipDtl.Count; i++)
                        {
                            DataStructures.WarehouseBin wb = PartFindBin(custShipDS.ShipDtl[i].PartNum, custShipDS.ShipDtl[i].OurReqQty);
                            custShipDS.ShipDtl[i].WarehouseCode = wb.warehouse;
                            custShipDS.ShipDtl[i].BinNum = wb.bin;
                            DLog.Log("Pulling part: " + custShipDS.ShipDtl[i].PartNum + " from: " + custShipDS.ShipDtl[i].WarehouseCode + ":" + custShipDS.ShipDtl[i].BinNum);
                        }


                        PUNCHHSWAG swag = (from ps in ds.PUNCHHSWAGs where ps.E10ORDERNUMBER == orderId select ps).Single();

                        shipHeadRow.TrackingNumber = swag.TRACKINGNUMBER;
                        shipHeadRow.Weight = swag.WEIGHT;

                        customerShipBO.UpdateMaster(custShipDS, false, false, false, false, false, false, false, shipHeadRow.PackNum, shipHeadRow.BTCustNum, out outstring[0], out outstring[1], out outstring[2], out outstring[3],
                            out outstring[4], out outstring[5], out outstring[6], out outstring[7], out outstring[8], out outstring[9], out outbool[1],
                            out outbool[2], out outstring[10], out outstring[11], out outbool[3], out outbool[4], out outbool[5], out outbool[6]);

                        shipHeadRow.ReadyToInvoice = true;

                        customerShipBO.UpdateMaster(custShipDS, false, false, false, false, false, false, false, shipHeadRow.PackNum, shipHeadRow.BTCustNum, out outstring[0], out outstring[1], out outstring[2], out outstring[3],
                            out outstring[4], out outstring[5], out outstring[6], out outstring[7], out outstring[8], out outstring[9], out outbool[1],
                            out outbool[2], out outstring[10], out outstring[11], out outbool[3], out outbool[4], out outbool[5], out outbool[6]);


                        DLog.Log("Order: " + orderId + " has been packed out to pack: " + shipHeadRow.PackNum);
                        dsr.SetResult(true, 0, "Order: " + orderId + " has been packed out to pack: " + shipHeadRow.PackNum);

                        swag.PACKNUM = shipHeadRow.PackNum;
                        ds.SubmitChanges();
                    }

                    return dsr;
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex, "Exception for order: " + orderId.ToString() + " cannot be found or has other issues: " + ex.Message);
                    dsr.SetResult(false, -1, "Exception for order: " + orderId.ToString() + " cannot be found or has other issues: " + ex.Message);
                    return dsr;
                }
            }
        }


        private static Boolean EnoughInventory(Int32 orderNum)
        {
            DLog.StartModule();
            #region//20190405- Amit : Property declare to call Epicor Api Caller 
            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
            //var rsLines = from od in cs.OrderDtls where od.OrderNum == orderNum select od;
            var rsLines = _EpicorBusinessApi.GetOrderLine().Where(od => od.OrderNum.Equals(orderNum));

            #endregion
            Boolean enough = true;
            #region//20190405- Amit : Property declare to call Epicor Api Caller 
            //foreach (OrderDtl oDtl in rsLines)
            IEnumerable<PartBin> rsPartBins = null;
            foreach (OrderDetailModel oDtl in rsLines)
            #endregion
            {
                #region//20190405- Amit : Property declare to call Epicor Api Caller 
                //var rsPartBins = from pb in cs.PartBins where pb.PartNum == oDtl.PartNum select pb;
                using (_EpicorBusinessApi = new EpicorBusinessApi())
                {
                    rsPartBins = _EpicorBusinessApi.GetPartBin().Where(pb => pb.PartNum.Equals(oDtl.PartNum));
                    #endregion
                    Decimal totalOnHand = 0.0m;

                    foreach (PartBin pBin in rsPartBins)
                    {
                        if (!pBin.WarehouseCode.ToLower().Contains("main")) continue;
                        totalOnHand += pBin.OnhandQty - pBin.JobAllocatedQty - pBin.AllocatedQty - pBin.JobPickedQty - pBin.JobPickingQty - pBin.PackedQty - pBin.SalesAllocatedQty;
                    }

                    if (oDtl.OrderQty > totalOnHand) enough = false;
                }
            }

            if (!enough) DLog.Log("There is not enough inventory to ship order: " + orderNum);

            return enough;
        }


        private static DataStructures.WarehouseBin PartFindBin(String partNum, Decimal qty)
        {
            #region//20190405- Amit : Property declare to call Epicor Api Caller 
            //EpicorE10DataContext db = new EpicorE10DataContext(DLog.CS);
            #endregion

            DataStructures.WarehouseBin wb = new DataStructures.WarehouseBin();

            //  First try 'MAIN/SHIP', then if not enough continue looking


            try
            {
                List<PartBin> partBins = null;
                #region//20190405- Amit : Property declare to call Epicor Api Caller 
                var WarehouseCodes = new string[] { "MAIN", "MAINREPL" };
                using (_EpicorBusinessApi = new EpicorBusinessApi())
                {
                    partBins = _EpicorBusinessApi.GetPartBin();
                }
                //var mainShip = (from pb in db.PartBins where pb.PartNum == partNum && (pb.WarehouseCode == "MAIN" || pb.WarehouseCode == "MAINREPL") && pb.BinNum == "SHIP" select pb).Single();
                var mainShip = partBins.SingleOrDefault(pb => pb.PartNum.Equals(partNum) & ((WarehouseCodes).Contains(pb.WarehouseCode)) & pb.BinNum.Equals("SHIP"));
                #endregion
                if (mainShip.OnhandQty >= qty)
                {
                    wb.warehouse = mainShip.WarehouseCode;
                    wb.bin = mainShip.BinNum;
                    DLog.Log(partNum + " satisfied by Main/Ship");
                    return wb;
                }

                DLog.Log("Not enough inventory of " + partNum + " (only - " + mainShip.OnhandQty + ") to satisfy a quantity of " + qty.ToString());


                #region//20190405- Amit : Property declare to call Epicor Api Caller 
                WarehouseCodes = new string[] { "MAIN", "MAINREPL", "RECSTG", "NCCO" };
                // var rsPartBins = from pb in db.PartBins                             where pb.PartNum == partNum && (pb.WarehouseCode == "Main" || pb.WarehouseCode == "MAINREPL" || pb.WarehouseCode == "RECSTG" || pb.WarehouseCode == "NCCO")                             select pb;
                var rsPartBins = partBins.Where(pb => pb.PartNum.Equals(partNum) & (WarehouseCodes).Contains(pb.WarehouseCode));
                #endregion
                foreach (PartBin pBin in rsPartBins)
                {
                    if (pBin.OnhandQty >= qty)
                    {
                        wb.warehouse = pBin.WarehouseCode;
                        wb.bin = pBin.BinNum;
                        return wb;
                    }
                }

                return wb;
            }
            catch (Exception ex)
            {
                DLog.Log("No inventory of " + partNum + " in Main/Ship");
            }
            #region//20190405- Amit : Property declare to call Epicor Api Caller 
            return wb;
            #endregion


        }


        private static Boolean GetOrderHeadsContainsPONum(String poNum)
        {

            try
            {
                //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
                using (_EpicorBusinessApi = new EpicorBusinessApi())
                {

                    //var rsOrders = from oh in cs.OrderHeds where oh.PONum == poNum select oh;
                    var rsOrders = _EpicorBusinessApi.GetOrderHead().Where(f => f.PONum.Equals(poNum));
                    if (rsOrders.Count() > 0)
                    {
                        DLog.Log("Order already exists with PONum: " + poNum, DLog.LogLevel.Error);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
                return true;
            }
        }


    }
}
