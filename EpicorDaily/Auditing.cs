using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;


using DotCommon;
using DotitBllDal;


namespace EpicorDaily
{

    static class Auditing
    {
        static DotitBllDal.DotitExtDataContext dd = new DotitBllDal.DotitExtDataContext(DLog.DS);
        static EpicorE10DataContext db = new EpicorE10DataContext(DLog.CS);

        static Boolean reasonToSendEmail = false;
        static String ordersWithQtyMain = "";
        static String ordersWithQtyOth = "";
        static String ordersWOQty = "";
        static String ordersWithQtyMainNCCO = "";
        static String ordersWithQtyOthNCCO = "";
        static String ordersWOQtyNCCO = "";
        static String emailMessage = "";
        static String listAnchors = "";

        static Int32 iInvOrders = 0;
        static Int32 iRecOrders = 0;
        static Int32 iBckOrders = 0;
        static Int32 iInvNCCOOrders = 0;
        static Int32 iRecNCCOOrders = 0;
        static Int32 iBckNCCOOrders = 0;

        static String h1 = "h1";
        static String h2 = "h2";
        static String h3 = "h3";
        static String h4 = "h4";
        static String p = "p";
        static String a = "a";
        static String ul = "ul";
        static String li = "li";
        static String href = "href";
        static String name = "name";
        static String id = "id";
        static String font = "font";
        static String color = "color";
        static String nbsp = "&nbsp;";
        static String lb = "<br />";


        public static void DoAuditing(String email)
        {
            DLog.StartModule();

            try
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday) return;


                CheckPartsNoWeight();
                CheckLowMarginParts(true); // exclude NCCO parts
                CheckPartsNoVolume();
                CheckShipToWOCountry();
                CheckShipToWOPhone();
                CheckPacksWOLines();
                CheckOrdersWOLines();
                CheckNotInvoicedWithInvoiceNumber();
                RunOutActiveNoInventory();
                MoreThan20Dispensers();
                PriceListAboutToExpire();
                PackLinesWithMisMatchedQty();
                CheckLowMarginParts(false); // get only NCCO parts


                if (reasonToSendEmail)
                {
                    listAnchors = tag(listAnchors, ul, id, "topOfPage");
                    emailMessage = listAnchors + ordersWithQtyMain + ordersWithQtyMainNCCO + ordersWithQtyOth
                        + ordersWithQtyOthNCCO + ordersWOQty + ordersWOQtyNCCO + emailMessage + tag("-----End of Auditing-----", p);
                    DEmail.SendEmailNotification(emailMessage, "Epicor Auditing Exceptions", "Dear Dot It Nation,", email);
                }

            }
            catch (Exception ex)
            {
                DLog.Log("Auditing issues: " + ex.ToString(), DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void CheckLowMarginParts(bool excludeNCCO)
        {
            DLog.StartModule();

            try
            {
                var rsP = from p in db.Parts
                          where (p.UnitPrice != 0)
                          group new
                          {
                              partNum = p.PartNum,
                              partDescription = p.PartDescription,
                              salesPrice = p.UnitPrice,
                              rC = p.RefCategory
                          }
                          by p.PartNum into p2
                          select new
                          {
                              partNum = p2.Key,
                              partDescription = p2.First().partDescription,
                              salesPrice = p2.Min(o => o.salesPrice),
                              rC = p2.First().rC
                          };
                if (excludeNCCO)
                {
                    rsP = rsP.Where(o => o.rC != "NCCOINV");
                } else
                {
                    rsP = rsP.Where(o => o.rC == "NCCOINV");
                }

                var rsPFC = from pfc in db.PartFIFOCosts
                            where (pfc.InActive == false) && (pfc.SourceType == "PUR-STK")
                            group new
                            {
                                partNum = pfc.PartNum,
                                totalCost = (pfc.FIFOLaborCost + pfc.FIFOBurdenCost + pfc.FIFOMaterialCost + pfc.FIFOSubContCost + pfc.FIFOMtlBurCost),
                            }
                            by pfc.PartNum into pfc2
                            select new
                            {
                                partNum = pfc2.Key,
                                totalCost = pfc2.Max(o => o.totalCost),
                            };

                var rsPjoinPFC = from p in rsP
                                 join pfc in rsPFC on p.partNum equals pfc.partNum
                                 where (pfc.totalCost != 0)
                                 select new
                                 {
                                     partNum = p.partNum,
                                     partDescription = p.partDescription,
                                     salesPrice = p.salesPrice,
                                     totalCost = pfc.totalCost,
                                     ratio = p.salesPrice / pfc.totalCost
                                 };

                rsPjoinPFC = rsPjoinPFC.Where(o => o.ratio < (decimal)1.2).OrderBy(o => o.ratio);

                if (rsPjoinPFC.Count() <= 0) return;
                reasonToSendEmail = true;

                if (excludeNCCO)
                {
                    emailMessage += Anchors(rsPjoinPFC.Count() + " Low Margin Parts (nonNCCO)", "lowMarginParts(nonNCCO)");
                } else
                {
                    emailMessage += Anchors(rsPjoinPFC.Count() + " Low Margin Parts (NCCO only)", "lowMarginParts(NCCO)");
                }

                emailMessage += DDynamicHTML.StartTable(new string[] { "PartNum", "Part Description", "Sales Price", "Total Cost", "Ratio" }, Align.Right);

                foreach (var part in rsPjoinPFC)
                {
                    emailMessage += DDynamicHTML.AddTableRow(new String[] { part.partNum, part.partDescription, part.salesPrice.ToString("0.00"), part.totalCost.ToString("0.00"), part.ratio.ToString("0.00") });
                }

                emailMessage += DDynamicHTML.EndTable();

            }
            catch (Exception ex)
            {
                DLog.Log(ex.Message, DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void PriceListAboutToExpire()
        {
            DLog.StartModule();

            try
            {
                DateTime dtFuture = DateTime.Now.AddDays(7);

                var rsPriceLists = from pl in db.PriceLsts where pl.EndDate != null && pl.EndDate <= dtFuture select pl;

                if (rsPriceLists.Count() <= 0) return;

                emailMessage += Anchors(rsPriceLists.Count() + " Pricelist(s) set to expire within next 7 days", "pricelistexpire");
                reasonToSendEmail = true;

                emailMessage += DDynamicHTML.StartTable(new String[]{"ListCode", "Name:", "EndDate:" }, Align.Left);

                foreach (var prlst in rsPriceLists)
                {
                    emailMessage += DDynamicHTML.AddTableRow(new String[] { prlst.ListCode, prlst.ListDescription, Convert.ToDateTime(prlst.EndDate).ToString("d-MMM") });
                }

                emailMessage += DDynamicHTML.EndTable();
            }
            catch (Exception ex)
            {
                DLog.Log(ex.Message, DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void RunOutActiveNoInventory()
        {
            DLog.StartModule();

            try
            {
                var rsBinLow = from p in db.Parts
                               join pb in db.PartBins on p.PartNum equals pb.PartNum
                               where p.RunOut == true && pb.OnhandQty <= 5 && p.InActive == false
                               group new { p.PartNum, p.RunOut, p.InActive, pb.WarehouseCode, pb.BinNum, pb.OnhandQty }
                               by p.PartNum into g
                               orderby g.Key
                               select new
                               {
                                   partNum = g.Key,
                                   runOut = g.First().RunOut,
                                   inActive = g.First().InActive,
                                   whse = g.First().WarehouseCode,
                                   bin = g.First().BinNum,
                                   onHandQty = g.Sum(o => o.OnhandQty)
                               };

                var rsRunOuts = from r in rsBinLow where r.onHandQty <= 5 group r by r.onHandQty into g select g;

                if (rsRunOuts.Count() <= 0) return;

                emailMessage += Anchors(rsBinLow.Count().ToString().PadLeft(5) + " Parts to run out, still active & have low on hand quantities. ", "runoutqty");
                reasonToSendEmail = true;

                emailMessage += DDynamicHTML.StartTable(new String[] { "Part", "Qty", "Bin", "Whse", "isRunOut", "isInActive" }, Align.Left);

                foreach (var run in rsRunOuts)
                {
                    emailMessage += DDynamicHTML.AddTableRow(new string[] { "&nbsp;" });
                    foreach (var abc in run)
                    {
                        emailMessage += DDynamicHTML.AddTableRow(new String[] { abc.partNum, run.Key.ToString("#0"), abc.bin, abc.whse, abc.runOut.ToString(), abc.inActive.ToString() });
                    }
                }

                emailMessage += DDynamicHTML.EndTable();
            }
            catch (Exception ex)
            {
                DLog.Log(ex.Message, DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void MoreThan20Dispensers()
        {
            DLog.StartModule();

            try
            {
                //  Change to 7 days after first run
                DateTime dtSince = DateTime.Now.AddDays(-7);
                Int32 iLimit = 20;

                String[] partsToCheck = new String[] { "Day2101", "Day1102", "Day1111", "Day2114", "Day1101", "Day1112", "Day1175", "Day2108" };

                var rsOrders = from od in db.OrderDtls
                               join oh in db.OrderHeds on od.OrderNum equals oh.OrderNum
                               join c in db.Customers on od.CustNum equals c.CustNum
                               where partsToCheck.Contains(od.PartNum) && od.OrderQty >= iLimit && oh.OrderDate > dtSince
                               group new { od.OrderNum, od.PartNum, od.OrderQty, c.Name } by new { od.OrderNum, od.PartNum } into g
                               orderby g.Key.OrderNum, g.Key.PartNum
                               select new { g.Key.OrderNum, g.Key.PartNum, sumQty = g.Sum(o => o.OrderQty), g.First().Name };

                if (rsOrders.Count() <= 0) return;

                emailMessage += Anchors(rsOrders.Count().ToString().PadLeft(5) + " Order lines with restricted quantity parts greater than or equal to " + iLimit, "limitedqty");
                reasonToSendEmail = true;

                emailMessage += "Participating Parts: " + String.Join(", ", partsToCheck) + lb + lb;
                emailMessage += DDynamicHTML.StartTable(new String[] {"Order","Part","Qty", "Customer" }, Align.Left);

                foreach (var od in rsOrders)
                {
                    emailMessage += DDynamicHTML.AddTableRow(new String[] { od.OrderNum.ToString(), od.PartNum, od.sumQty.ToString("#0"), od.Name });
                }

                emailMessage += DDynamicHTML.EndTable();
            }
            catch (Exception ex)
            {
                DLog.Log(ex.Message, DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void PackLinesWithMisMatchedQty()
        {
            DLog.StartModule();

            try
            {
                DateTime dtSince = DateTime.Now.AddDays(-7);
                var rsPackDtls = from sd in db.ShipDtls
                                 join od in db.OrderDtls on new { sd.OrderNum, sd.PartNum } equals new { od.OrderNum, od.PartNum }
                                 join sh in db.ShipHeads on sd.PackNum equals sh.PackNum
                                 where sd.ChangeDate > dtSince
                                 group new
                                 {
                                     od.OrderQty,
                                     sd.OurJobShipQty,
                                     sd.OurInventoryShipQty,
                                     sd.ChangeDate,
                                     sd.PackLine,
                                     sh.ShipPerson,
                                     sd.OrderNum
                                 }
                                 by new { packNum = sd.PackNum, partNum = sd.PartNum } into g
                                 orderby g.Key.packNum, g.Key.partNum
                                 select new
                                 {
                                     orderQty = g.Sum(a => a.OrderQty),
                                     packQty = (g.Sum(a => a.OurJobShipQty) + g.Sum(b => b.OurInventoryShipQty)),
                                     changeDate = g.First().ChangeDate,
                                     packNum = g.Key.packNum,
                                     packLine = g.First().PackLine.ToString(),
                                     shipPerson = g.First().ShipPerson,
                                     partNum = g.Key.partNum,
                                     orderNum = g.First().OrderNum
                                 };

                if (rsPackDtls.Count() <= 0) return;

                emailMessage += Anchors("Pack(s) with MisMatched Quantities in the last 7 days", "packmismatchqty");
                reasonToSendEmail = true;

                foreach (var sdtl in rsPackDtls)
                {
                    if (sdtl.orderQty == sdtl.packQty) continue;

                    var rsOtherPacks = from sd in db.ShipDtls where sd.OrderNum == sdtl.orderNum && sd.PackNum != sdtl.packNum && sd.PartNum == sdtl.partNum select sd;

                    if (rsOtherPacks.Count() > 0)
                    {
                        Int32 newPackQty = Convert.ToInt32(sdtl.packQty);

                        foreach (ShipDtl sd in rsOtherPacks)
                        {
                            newPackQty += Convert.ToInt32(sd.OurInventoryShipQty + sd.OurJobShipQty);
                        }

                        if (sdtl.orderQty == newPackQty) continue;          //  Rest of the order was filled with a different pack out
                    }

                    emailMessage += "Pack: " + sdtl.packNum + " orderQty: " + sdtl.orderQty.ToString("#0") + " packQty: " + sdtl.packQty.ToString("#0") + " part: " + sdtl.partNum + " processsed on: "
                        + Convert.ToDateTime(sdtl.changeDate).ToString("d-MMM") + " by: " + sdtl.shipPerson;
                }

            }
            catch (Exception ex)
            {
                DLog.Log(ex.Message, DLog.LogLevel.Error);
            }

            DLog.EndModule();
        }


        private static void OrderWithCreditHold()
        {
            DLog.StartModule();

            try
            {
                var rsOrders = from o in db.OrderHeds
                               join c in db.Customers on o.CustNum equals c.CustNum
                               where o.OpenOrder == true && o.OrderDate < DateTime.Now.AddDays(-2) && c.CreditHold == true
                               orderby c.Name, o.OrderDate
                               select new { o.OrderNum, c.Name, c.TermsCode, c.CreditHold, o.DocOrderAmt, o.OrderDate, c.PhoneNum, c.CustID };

                emailMessage += Anchors(rsOrders.Count().ToString().PadLeft(5) + " Orders with Customers on Credit Hold", "creditholdorder");
                reasonToSendEmail = true;
                foreach (var ord in rsOrders)
                {
                    String orderDate = pad(Convert.ToDateTime(ord.OrderDate).ToString("d MMM yy"), 10);
                    emailMessage += "Customer: " + pad(ord.CustID, 10) + pad(ord.Name, 28) + pad(ord.PhoneNum, 16) + "Credit Hold with Order: "
                        + pad(ord.OrderNum.ToString(), 8) + orderDate + " for " + pad(ord.DocOrderAmt.ToString("$#0.00"), 10, Align.Decimal) + lb;
                }
            }
            catch (Exception)
            {
                DLog.Log("Currently no Open Orders with Credit Hold Customers");
            }

            DLog.EndModule();
        }


        private static void OrdersOnHold()
        {
            DLog.StartModule();

            try
            {
                var rsOrders = from o in db.OrderHeds where o.OpenOrder == true && o.ReadyToCalc == false select new { o.OrderNum, o.DocOrderAmt, o.OrderDate };

                if (rsOrders.Count() <= 0) return;

                emailMessage += Anchors(rsOrders.Count().ToString().PadLeft(5) + " Orders on Hold", "ordersonhold");
                reasonToSendEmail = true;
                foreach (var ord in rsOrders)
                {
                    String orderDate = pad(Convert.ToDateTime(ord.OrderDate).ToString("d MMM yy"), 10);
                    emailMessage += "Order: " + pad(ord.OrderNum.ToString(), 8) + orderDate + " for " + pad(ord.DocOrderAmt.ToString("$#0.00"), 10, Align.Decimal) + " is on hold" + lb;
                }
            }
            catch (Exception)
            {
                DLog.Log("Currently no Orders on Hold");
            }

            DLog.EndModule();
        }


        private static void OpenOrders()
        {
            DLog.StartModule();
            Int32 daysBack = 14;

            try
            {
                //  Exclude Nesbits from this audit - c.CustID != "56413"

                var rsOrders = from o in db.OrderHeds
                               join c in db.Customers on o.CustNum equals c.CustNum
                               where o.OpenOrder == true && o.OrderDate < DateTime.Now.AddDays(daysBack * -1) && c.CreditHold == false && c.CustID != "56413"
                               orderby o.NeedByDate
                               select new { o.OrderNum, c.Name, c.TermsCode, c.CreditHold, o.DocOrderAmt, o.OrderDate, c.PhoneNum, c.CustID, o.ShipOrderComplete, o.NeedByDate };

                if (rsOrders.Count() <= 0) return;

                emailMessage += Anchors(rsOrders.Count().ToString() + " Orders older than " + daysBack.ToString() + " days and still Open", "openorders");
                reasonToSendEmail = true;

                String customerHeader = ("Cust Id").PadLeft(8) + ("   Name").PadLeft(20) + ("Order").PadLeft(10) + ("Order Date").PadLeft(10) + ("Need By").PadLeft(10) + ("Order Amt").PadLeft(10) + "Ship Compl" + lb;

                foreach (var ord in rsOrders)
                {
                    String oDate = Convert.ToDateTime(ord.OrderDate).ToString("d MMM yy").PadLeft(10);
                    String needDate = Convert.ToDateTime(ord.NeedByDate).ToString("d MMM yy").PadLeft(10);
                    String order = ord.CustID.PadLeft(8) + ord.Name.PadLeft(20) + ord.OrderNum.ToString().PadLeft(10)
                                    + oDate + needDate + ord.DocOrderAmt.ToString("$ #,##0.00").PadLeft(10) + ord.ShipOrderComplete.ToString() + lb;

                    IEnumerable<OrderDtl> orderLines = from od in db.OrderDtls where od.OrderNum == ord.OrderNum && od.OpenLine == true select od;

                    Boolean orderReady = true;
                    Boolean allInMain = true;

                    order += pad("Line", 6) + pad("Part", 30) + pad("Ord Qty", 8) + "Avail Qty" + lb;

                    Decimal availableQty = 0;
                    Decimal availableQtyMain = 0;

                    foreach (OrderDtl dtl in orderLines)
                    {
                        availableQty = 0;
                        availableQtyMain = 0;
                        IEnumerable<PartQty> partQties = from pq in db.PartQties where pq.PartNum == dtl.PartNum select pq;

                        String availInventory = "";

                        foreach (PartQty qty in partQties)
                        {
                            availableQty += qty.OnHandQty;
                            if (qty.WarehouseCode.ToUpper() == "MAIN") availableQtyMain += qty.OnHandQty;
                            availInventory += pad(qty.OnHandQty.ToString("#,##0"), 36, Align.Decimal) + " " + qty.WarehouseCode + lb;
                        }

                        order += pad(dtl.OrderLine.ToString(), 7) + pad(dtl.PartNum, 20) + pad(dtl.OrderQty.ToString("#,##0"), 8);
                        if (availableQty < dtl.OrderQty)
                        {
                            orderReady = false;
                            order += tag(availableQty.ToString("#,##0"), font, color, "red");
                        }
                        else
                        {
                            if (availableQtyMain < dtl.OrderQty) allInMain = false;
                            order += availableQty.ToString("#,##0").PadLeft(8);
                        }
                        if (availableQty >= dtl.OrderQty && availableQtyMain < dtl.OrderQty) order += availInventory;
                        order += lb;
                    }

                    if (orderReady)
                    {
                        if (allInMain)
                        {
                            if (ord.CustID == "61305")
                            {
                                ordersWithQtyMainNCCO += order;
                                iInvNCCOOrders += 1;
                            }
                            else
                            {
                                ordersWithQtyMain += order;
                                iInvOrders += 1;
                            }
                        }
                        else
                        {
                            if (ord.CustID == "61305")
                            {
                                ordersWithQtyOthNCCO += order;
                                iRecNCCOOrders += 1;
                            }
                            else
                            {
                                ordersWithQtyOth += order;
                                iRecOrders += 1;
                            }
                        }
                    }
                    else
                    {
                        if (ord.CustID == "61305")
                        {
                            ordersWOQtyNCCO += order;
                            iBckNCCOOrders += 1;
                        }
                        else
                        {
                            ordersWOQty += order;
                            iBckOrders += 1;
                        }
                    }
                }

                if (iInvOrders > 0)
                {
                    emailMessage = Anchors(iInvOrders.ToString() + " Orders with Inventory in Main", "qtymain") + customerHeader + ordersWithQtyMain;
                }
                if (iInvNCCOOrders > 0)
                {
                    emailMessage = Anchors(iInvNCCOOrders.ToString() + " NCCO Orders with Inventory in Main", "qtymainncco") + customerHeader + ordersWithQtyMainNCCO;
                }
                if (iInvOrders > 0)
                {
                    emailMessage = Anchors(iInvOrders.ToString() + " Orders with Inventory in Main", "qtyoth") + customerHeader + ordersWithQtyOth;
                }
                if (iRecNCCOOrders > 0)
                {
                    emailMessage = Anchors(iRecNCCOOrders.ToString() + " NCCO Orders with Inventory", "qtyothncco") + customerHeader + ordersWithQtyOthNCCO;
                }
                if (iBckOrders > 0)
                {
                    emailMessage = Anchors(iBckOrders.ToString() + " Orders without enough Inventory", "noqty") + customerHeader + ordersWOQty;
                }
                if (iBckNCCOOrders > 0)
                {
                    emailMessage = Anchors(iBckNCCOOrders.ToString() + " NCCO Orders without enough Inventory", "noqtyncco") + customerHeader + ordersWOQtyNCCO;
                }



            }
            catch (Exception)
            {
                DLog.Log("Currently no Open Orders older than " + daysBack + " days");
            }

            DLog.EndModule();
        }


        private static void CheckNotInvoicedWithInvoiceNumber()
        {
            DLog.StartModule();

            try
            {
                var rsPackNums = (from sh in db.ShipHeads
                                  join i in db.InvcDtls on sh.PackNum equals i.PackNum
                                  where sh.Invoiced == false
                                  select new { sh.PackNum, i.InvoiceNum }).ToList();

                if (rsPackNums.Count <= 0)
                {
                    DLog.Log("Currently no Invoices without being Invoiced");
                    return;
                }

                emailMessage += Anchors(rsPackNums.Count().ToString().PadLeft(5) + " Invoiced Orders, but not marked as shipped", "notinvoiced");
                reasonToSendEmail = true;
                foreach (var pack in rsPackNums)
                {
                    emailMessage += "PackNum: " + pack.PackNum.ToString() + " shows not invoiced, but has an invoice number: " + pack.InvoiceNum.ToString() + lb;
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Issues with CheckNotInvoicedWithInvoiceNumber: " + ex.Message);
            }

            DLog.EndModule();
        }


        private static void CheckOrdersWOLines()
        {
            DLog.StartModule();

            try
            {
                List<OrderHed> rsOrders = (from oh in db.OrderHeds
                                           where !db.OrderDtls.Any(f => f.OrderNum == oh.OrderNum) && oh.OpenOrder == true
                                           select oh).ToList();

                if (rsOrders.Count() <= 0)
                {
                    DLog.Log("Currently no empty Orders: ");
                    return;
                }

                emailMessage += Anchors(rsOrders.Count().ToString().PadLeft(5) + " Orders without line items", "orderwolines");
                reasonToSendEmail = true;
                foreach (OrderHed order in rsOrders)
                {
                    emailMessage += "Order: " + order.OrderNum.ToString() + " created by: " + order.EntryPerson + " has no line items" + lb;
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Currently no empty Orders due to exception: " + ex.Message);
            }

            DLog.EndModule();
        }


        private static void CheckPacksWOLines()
        {
            DLog.StartModule();

            try
            {
                List<ShipHead> rsShipHeads = (from sh in db.ShipHeads
                                              where !db.ShipDtls.Any(f => f.PackNum == sh.PackNum) && sh.Voided == false && sh.ReadyToInvoice == false
                                              select sh).ToList();

                if (rsShipHeads.Count() <= 0)
                {
                   DLog.Log("Currently no empty Packs");
                   return;
                }

                emailMessage += Anchors(rsShipHeads.Count().ToString().PadLeft(5) + " Packs without line items", "packwolines");
                reasonToSendEmail = true;
                foreach (ShipHead shs in rsShipHeads)
                {
                    emailMessage += "PackNum: " + shs.PackNum.ToString() + " packed by " + shs.EntryPerson + " has no line items";
                    if (!String.IsNullOrWhiteSpace(shs.TrackingNumber)) emailMessage += ", but has a tracking number: " + shs.TrackingNumber;
                    emailMessage += lb;
                }
                //EpicorCleanup.DoEpicorCleanup();
            }
            catch (Exception ex)
            {
                DLog.Log("Currently no empty Packs");
            }

            DLog.EndModule();
        }


        private static void CheckPartsNoWeight()
        {
            DLog.StartModule();

            try
            {
                var rsParts = from p in db.Parts
                              join pb in db.PartBins on p.PartNum equals pb.PartNum
                              where p.GrossWeight <= 0.0m && !p.InActive && !p.BuyToOrder && pb.OnhandQty > 10
                              group p by p.PartNum into g
                              orderby g.Key
                              select g.Key;

                if (rsParts.Count() == 0) return;

                emailMessage += Anchors(rsParts.Count().ToString().PadLeft(5) + " Parts exist with 0.0 weight", "noweight");
                reasonToSendEmail = true;

                foreach (String part in rsParts)
                {
                    emailMessage += "Part: " + part + lb;
                }

            }
            catch (Exception ex) { DLog.LogErr(ex); }

            DLog.EndModule();
        }


        private static void CheckPartsNoVolume()
        {
            DLog.StartModule();

            try
            {
                var rsParts = from p in db.Parts
                              join pb in db.PartBins on p.PartNum equals pb.PartNum
                              where p.NetVolume <= 0.0m && !p.InActive && !p.BuyToOrder && pb.OnhandQty > 480
                              group p by p.PartNum into g
                              orderby g.Key
                              select g.Key;

                if (rsParts.Count() == 0) return;

                emailMessage += Anchors(rsParts.Count().ToString().PadLeft(5) + " Parts exist with 0 volume", "novolume");
                reasonToSendEmail = true;

                foreach (String part in rsParts)
                {
                    emailMessage += "Part: " + part + lb;
                }

            }
            catch (Exception ex) { DLog.LogErr(ex); }

            DLog.EndModule();
        }


        private static void CheckShipToWOPhone()
        {
            DLog.StartModule();

            try
            {
                //  CustNum 1 - National Checking, 22 - FIFO Innovations, 7620 - RPMCO
                var rsShipTos = from st in db.ShipTos
                                join c in db.Customers on st.CustNum equals c.CustNum
                                where st.PhoneNum == "" && st.ShipToNum != "" && (st.CustNum == 1 || st.CustNum == 22 || st.CustNum == 7620)
                                select new { c.CustID, c.Name, c.ShipToNum };

                if (rsShipTos.Count() == 0)
                {
                    DLog.Log("Currently no ship tos without Phone");
                    return;
                }
                DLog.Log("tempshipWOphone");
                emailMessage += Anchors(rsShipTos.Count().ToString().PadLeft(5) + " ShipTos without Phone Numbers", "wophone");
                DLog.Log("tempshipWOphone2");
                reasonToSendEmail = true;

                foreach (var shipTo in rsShipTos)
                {
                    emailMessage += "Customer: " + shipTo.CustID + ", " + shipTo.Name + " ShipTo Number: " + shipTo.ShipToNum + " has no Phone number" + lb;
                    DLog.Log("tempshipWOphone4: " + "Customer: " + shipTo.CustID + ", " + shipTo.Name + " ShipTo Number: " + shipTo.ShipToNum + " has no Phone number" + lb);
                }

            }
            catch (Exception ex)
            {
                DLog.Log("Issues with CheckShipToWOPhone: " + ex.ToString(), DLog.LogLevel.Error, true);
            }

            DLog.EndModule();
        }


        private static void CheckShipToWOCountry()
        {
            DLog.StartModule();

            try
            {
                var rsShipTos = from st in db.ShipTos where st.Country == "" && st.ShipToNum != "" select st;

                if (rsShipTos.Count() == 0)
                {
                    DLog.Log("Currently no ship tos without Country");
                    return;
                }

                emailMessage += Anchors(rsShipTos.Count().ToString().PadLeft(5) + " ShipTos without Countries", "wocountry");
                reasonToSendEmail = true;

                foreach (ShipTo shipTo in rsShipTos)
                {
                    var rsCust = (from c in db.Customers where c.CustNum == shipTo.CustNum select c).Single();
                    emailMessage += "Customer: " + rsCust.CustID + ", " + rsCust.Name + " ShipTo Number: " + shipTo.ShipToNum + " has no Country" + lb;
                }
            }
            catch (Exception ex)
            {
                DLog.Log("Issues with CheckShipToWOCountry: " + ex.ToString(), DLog.LogLevel.Error, true);
            }

            DLog.EndModule();
        }


        private static void AuditingDotitExt()
        {
            DLog.StartModule();


            DLog.EndModule();
        }


        private static String Anchors(String message, String anchor = "")
        {
            listAnchors += tag(tag(message, a, href, anchor), li);
            return tag(tag(message, a, name, anchor) + tag(" go to top", a, href, "topOfPage"), h3);
        }


        private static String pad(String message, Int32 length, Align align = Align.Left)
        {
            if (message.Length >= length) return message.Substring(0, length);
            switch (align)
            {
                case Align.Center:
                    Decimal dLen = Math.Floor(Convert.ToDecimal((length - message.Length) / 2));
                    break;

                case Align.Right:
                    break;

                case Align.Decimal:
                    for (Int32 idec = 0; idec < (length - message.Length); idec++)
                    {
                        message = nbsp + message;
                    }
                    break;

                default:
                    for (Int32 ileft = 0; ileft < (length - message.Length); ileft++)
                    {
                        message += nbsp;
                    }
                    break;
            }
            return message;
        }


        private static String tag(String message, String tag, String attrib = "", String attribValue = "")
        {
            String returnMsg = "<" + tag;
            if (attrib != null)
            {
                if (!String.IsNullOrWhiteSpace(attrib) && !String.IsNullOrWhiteSpace(attribValue))
                {
                    returnMsg += " " + attrib + "='";
                    if (attrib.ToUpper() == "HREF") returnMsg += "#";
                    returnMsg += attribValue + "' ";
                }
            }
            return returnMsg + ">" + message + "</" + tag + ">";
        }


    }
}
