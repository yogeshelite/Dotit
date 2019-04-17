using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Erp.BO;
using Erp.Proxy.BO;
using Ice.Lib.Framework;
using Ice.Core;

using DotCommon;
//using DotitBllDal;


namespace EpicorDaily
{
    public class AFS
    {
        static String configOrderFile = @"C:\Dotit\Config\AFSNotification.xml";        

        public static void ProcessNewAFSLineItems(Session session)
        { 
            DLog.StartModule();
            using (EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS))
            {
                try
                { 

                    var rsOrders = from od in cs.OrderDtls
                                   join oh in cs.OrderHeds on od.OrderNum equals oh.OrderNum
                                   join c in cs.Customers on oh.CustNum equals c.CustNum
                                   where od.OpenLine == true && od.ProdCode == "afs"
                                   orderby oh.OrderNum
                                   select new
                                   {
                                       od.PartNum,
                                       od.OrderQty,
                                       od.UnitPrice,
                                       od.LineDesc,
                                       od.OrderLine,
                                       oh.OrderNum,
                                       c.CustID,
                                       c.Name,
                                       oh.OrderComment,
                                       oh.ShipComment
                                   };

                    DLog.Log("there are: " + rsOrders.Count() + " records to process");

                    Int32 prevOrderNum = 0;
                    String body = "";

                    foreach (var ord in rsOrders)
                    {
                        if (prevOrderNum != ord.OrderNum)
                        {
                            if (!String.IsNullOrWhiteSpace(body))
                            {
                                SendAFSManualNotification(body, prevOrderNum);
                            }

                            body = "Customer: " + ord.Name + " with CustId: " + ord.CustID + " just ordered: " + ord.OrderNum + " the following classes:<br /><br />";
                            body += "Part: " + ord.PartNum + " - " + ord.LineDesc + "   || Quantity: " + ord.OrderQty.ToString("#0") + " for: " + ord.UnitPrice.ToString("#0.00") + "<br /><br />";
                            body += "Order Comment: " + ord.OrderComment + "<br />";
                            body += "Ship Comment: " + ord.ShipComment + "<br />";
                        }
                        else
                        {
                            body += "Part: " + ord.PartNum + " - " + ord.LineDesc + "   || Quantity: " + ord.OrderQty.ToString("#0") + " for: " + ord.UnitPrice.ToString("#0.00") + "<br />";
                        }

                        prevOrderNum = ord.OrderNum;
                    }

                    SendAFSManualNotification(body, prevOrderNum);
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex);
                }
            }
        }


        private static void SendAFSManualNotification(String body, Int32 orderNum)
        {
            DLog.StartModule();

            List<Order> listOrders = DSerial.ReadXMLList<Order>(typeof(List<Order>), configOrderFile);

            if (listOrders == null)
            {
                listOrders = new List<Order>();
                DLog.Log("OrderNum: " + orderNum + " ConfigFile: " + configOrderFile + " does not exist - starting new list");
            }

            var rsNeedToNotify = from o in listOrders where o.orderNum == orderNum select o;

            if (rsNeedToNotify.Count() > 0)
            {
                DLog.Log("Order: " + orderNum + " already notified");
                return;
            }

            try
            {
                DEmail.SendEmailNotification(body, "AFS Alert - New Order for AFS Classes!", "Hey AFS", "svanniman@dotit.com;help@alwaysfoodsafe.com;rtrafford@dotit.com");
                Order ord = new Order();
                ord.orderNum = orderNum;
                listOrders.Add(ord);
                DSerial.SaveXMLList<Order>(listOrders, configOrderFile);
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
            }
        }



        public class Order
        {
            public Int32 orderNum { get; set; }
        }

    }
}
