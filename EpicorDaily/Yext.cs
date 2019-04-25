using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Ice.Core;
using Newtonsoft.Json;
using RestSharp;

using DotCommon;
using EpicorDaily.Model;
using DotitBllDal;
//using DotitBllDal;

namespace EpicorDaily
{
    public class Yext
    {
        //private static String baseURL = "https://api.yext.com/v2/accounts";
        private static String baseURL = "https://sandbox.yext.com/v2/";
        private static String accountId = "1452463";
        //private static String accountId = "1505906";
        private static String apiKey = "?api_key=e2d03413ec99ab59baa056cedfe08269&v=" + DateTime.Now.ToString("yyyMMdd");
        private static String apiMageKey = "&value=12324e20-4fae-4495-afef-78175436e488";
        private static String apiMageBase = "PartsValidate/emailapi.php?order_number=";

        private static readonly HttpClient client = new HttpClient();
        #region//20190404- Amit : Property declare to call Epicor Api Caller 
        public static EpicorBusinessApi _EpicorBusinessApi { get; set; }
        #endregion


        public static void OrderProcessing(Session session)
        {
            DLog.StartModule();
            #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 

            using (_EpicorBusinessApi = new EpicorBusinessApi())
            {
                //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
                #endregion
                DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

                try
                {
                    #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 
                    var rsOrders = from od in cs.OrderDtls where (od.PartNum == "Yext-Mth" || od.PartNum == "Yext-Yr") && od.OpenLine == true select od;
                    //var rsOrders = _EpicorBusinessApi.GetOrderLine().Where(f => f.OpenLine && ((new string[] { "Yext-Mth", "Yext-Yr" }).Contains(f.PartNum)));
                    #endregion
                    DLog.Log("There are " + rsOrders.Count() + " line(s) with new Yext orders");

                    if (rsOrders.Count() <= 0) return;
                    YEXT_HEADER yextHeader;
                    foreach (OrderDetailModel oDtl in rsOrders)
                    {
                        var rsDetails = from yd in ds.YEXT_DETAILs where yd.EPICORORDERNUM == oDtl.OrderNum select yd;

                        if (rsDetails.Count() > 0)              //  Issues if the order line is not closed and yet record exists in database
                        {
                            DLog.Log("Returned orders already in detail table: " + rsDetails.Count(), DLog.LogLevel.Error);
                            DEmail.SendEmailNotification("Yext issues - check log", "Yext issues", "Yo", "svanniman@dotit.com");
                            continue;
                        }

                        yextHeader = new YEXT_HEADER();

                        Boolean isNew = true;
                        Int32 custNum = 0;
                        MagentoResponse msp = new MagentoResponse();
                        //12324e20-4fae-4495-afef-78175436e488 guid for transaction

                        //  If CustId 4, which is equal to CustNum 5030, then we need the magento customer number as well - if neither exist, then we have to add to the table
                        DLog.Log("CustNum: " + oDtl.CustNum);

                        try
                        {
                            String url = DLog.mageAPI + apiMageBase + oDtl.OrderNum + apiMageKey;
                            DLog.Log("URL for Mage Call: " + url);
                            msp = DRest.RestGet<MagentoResponse>(url);

                            if (!msp.success)
                            {
                                DLog.Log(msp.returnMessage + " : " + url, DLog.LogLevel.Error, true);
                            }

                            Int32.TryParse(msp.customer_id, out custNum);

                        }
                        catch (Exception ex)
                        {
                            DLog.LogErr(ex, "Calling JH api", true);
                            continue;
                        }

                        if (oDtl.CustNum == 5030)           // CustId 4
                        {
                            try
                            {
                                var rsSubscriptionHeaders = from yd in ds.YEXT_HEADERs where yd.MAGENTOCUSTNUM == custNum select yd;

                                if (rsSubscriptionHeaders.Count() == 1)
                                {
                                    DLog.Log("setting yextHeader");
                                    yextHeader = rsSubscriptionHeaders.FirstOrDefault();

                                    isNew = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                DLog.LogErr(ex, "reading rsSubscriptionHeaders", true);
                                continue;
                            }
                        }
                        else
                        {
                            try
                            {
                                var rsSubscriptionHeaders2 = from yd in ds.YEXT_HEADERs where yd.EPICORCUSTNUM == oDtl.CustNum select yd;

                                if (rsSubscriptionHeaders2.Count() == 1)
                                {
                                    DLog.Log("setting yextHeader");
                                    yextHeader = rsSubscriptionHeaders2.FirstOrDefault();
                                    isNew = false;
                                }

                            }
                            catch (Exception ex)
                            {
                                DLog.LogErr(ex, "reading rsSubscriptionHeaders2", true);
                                continue;
                            }
                        }

                        Boolean isOriginallyActive = false;

                        if (!isNew)
                        {
                            DLog.Log("Have Customer: " + yextHeader.EPICORCUSTNUM + " : " + yextHeader.MAGENTOCUSTNUM + " : " + yextHeader.MAGENTOEMAIL);
                            DLog.Log("Have Yext Information - Active: " + yextHeader.ISACTIVE + " Renew: " + yextHeader.RENEWALDATE.ToString("M/d/yy") + " Start Date: " + yextHeader.STARTDATE.ToString("M/d/yy"));
                            isOriginallyActive = yextHeader.ISACTIVE;
                        }

                        DataStructures.DotitServiceResult dsr = ShippingE10.CreatePackoutSubscription(session, oDtl.OrderNum, "Yext");

                        if (dsr.success)
                        {
                            Int32 months = 0;
                            DateTime dtStart = DateTime.Now;
                            DateTime dtRenewal = DateTime.Now;

                            if (oDtl.PartNum.ToUpper() == "YEXT-MTH") months = Convert.ToInt32(oDtl.OrderQty);
                            if (oDtl.PartNum.ToUpper() == "YEXT-YR") months = 12 * Convert.ToInt32(oDtl.OrderQty);

                            if (months < 1)
                            {
                                DLog.Log("Yext Months cannot be less than 1 for Customer Id: " + oDtl.CustNum + " with regards to Order: " + oDtl.OrderNum, DLog.LogLevel.Error, true);
                                continue;
                            }

                            if (yextHeader.ISACTIVE && yextHeader.RENEWALDATE != null)
                            {
                                dtRenewal = Convert.ToDateTime(yextHeader.RENEWALDATE);
                                DLog.Log("existing renewal date: " + dtRenewal.ToString("d MMM yy"));
                            }

                            dtRenewal = dtRenewal.AddMonths(months);
                            DLog.Log("Extended/Creating Subscription to: " + dtRenewal.ToString("d MMM yy") + " for Customer Id: " + oDtl.CustNum + " with regards to Order: " + oDtl.OrderNum);

                            yextHeader.NEXTFEE = oDtl.DocUnitPrice;
                            yextHeader.RENEWALDATE = dtRenewal;

                            if (isNew)
                            {
                                yextHeader.CREATEDATE = dtStart;
                                yextHeader.CREATEDBY = "EpicorDaily";
                                yextHeader.MODIFIEDBY = yextHeader.CREATEDBY;
                                yextHeader.MODIFIEDDATE = yextHeader.CREATEDATE;
                                yextHeader.EPICORCUSTNUM = oDtl.CustNum;
                                yextHeader.ISACTIVE = true;
                                yextHeader.ISAUTORENEW = true;
                                if (msp.success)
                                {
                                    yextHeader.MAGENTOCUSTNUM = custNum;
                                    yextHeader.MAGENTOEMAIL = msp.customer_email;
                                }
                                yextHeader.STARTDATE = dtStart;
                                yextHeader.YEXTCUSTNUM = "";
                                yextHeader.YEXTSSOTOKEN = "";
                                ds.YEXT_HEADERs.InsertOnSubmit(yextHeader);
                                ds.SubmitChanges();
                            }
                            else
                            {
                                yextHeader.MODIFIEDBY = "EpicorDaily";
                                yextHeader.MODIFIEDDATE = DateTime.Now;
                                ds.SubmitChanges();
                            }

                            AddYextDetail(yextHeader, oDtl);


                            //if (isYextCustomerSuccessful)
                            //{
                            //}
                            //else
                            //{
                            //    DLog.Log("Adding Yext Details was not successful - check log for details", DLog.LogLevel.Error, true);
                            //}


                            //  Still need to call Yext and add if not previously active.

                            Boolean isAddedToYext = false;

                            if (!isOriginallyActive)
                            {
                                //isAddedToYext = YextAPIAddAccount(ref cud);

                                if (!isAddedToYext)
                                {
                                    DLog.Log("Order: " + oDtl.OrderNum + " was not successfully added to Yext - abandon order item");
                                    continue;
                                }
                            }
                            //TODO  Do we need to extend active date in Yext?  Possible update?

                            SendNotifications(yextHeader, oDtl, isNew);
                        }
                        else
                        {
                            DLog.Log(dsr.returnMessage, DLog.LogLevel.Error, true, null, "", "svanniman@dotit.com");
                        }
                    }
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex, "Yext OrderProcessing", true);
                }

            }
        }

        #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 
        //private static void SendNotifications(YEXT_HEADER yextHeader, OrderDtl oDtl, Boolean isNew)
        private static void SendNotifications(YEXT_HEADER yextHeader, OrderDetailModel oDtl, Boolean isNew)
        #endregion
        {
            String msg = "Customer: " + yextHeader.EPICORCUSTNUM;
            String subj = "New Yext Customer! - Test";
            if (oDtl.CustNum == 5030)
            {
                msg += " Magento Customer: " + yextHeader.MAGENTOCUSTNUM + " email: " + yextHeader.MAGENTOEMAIL;
            }
            msg += " has placed and order for Yext.  PartNum: " + oDtl.PartNum;
            if (!isNew)
            {
                subj = "Yext Customer Renewing!";
            }

            if (DLog.isTest)
            {
                subj += " - Test";
                DEmail.SendEmailNotification(msg, "New Yext Customer! - Test", "Hey Rachel and Steve", "svanniman@dotit.com");
            }
            else
            {
                DEmail.SendEmailNotification(msg, "New Yext Customer! - Test", "Hey Rachel and Steve", "rmorgan@dotit.com;svanniman@dotit.com;cgibson@dotit.com");
            }
        }
        #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 
        //private static void AddYextDetail(YEXT_HEADER yh, OrderDtl oDtl)
        private static void AddYextDetail(YEXT_HEADER yh, OrderDetailModel oDtl)
        #endregion
        {
            DLog.StartModule();

            try
            {
                DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

                YEXT_DETAIL yd = new YEXT_DETAIL();

                yd.ENTRYPERSON = yh.MODIFIEDBY;
                yd.EPICORORDERNUM = oDtl.OrderNum;
                if (yh.MODIFIEDBY == "EpicorDaily")
                {
                    yd.ISONLINE = true;
                }
                else
                {
                    yd.ISONLINE = false;
                }
                yd.ORDERDATE = (DateTime)oDtl.RequestDate;
                yd.ORDERQTY = (Int32)oDtl.OrderQty;
                yd.PARTNUM = oDtl.PartNum;
                yd.PRICE = oDtl.DocUnitPrice;
                yd.YEXTID = yh.YEXTID;

                ds.YEXT_DETAILs.InsertOnSubmit(yd);
                ds.SubmitChanges();
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex, "AddYextDetail", true);
                throw;
            }
        }

        private static Boolean YextAPIAddAccount(ref Customer_UD cud, Customer cus)
        {
            DLog.StartModule();

            try
            {
                if (!CheckHealth()) return false;

                if (!String.IsNullOrWhiteSpace(cud.YextCustomerNumber_c))
                {
                    DLog.Log("Customer already exists:  " + cud.YextCustomerNumber_c);
                    return true;
                }

                var response = HttpPost.Post(baseURL, new NameValueCollection()
                {
                });

                String result = Encoding.UTF8.GetString(response);

            }
            catch (Exception ex)
            {
                DLog.LogErr(ex, "YextAPIAddAccount", true);
                return false;
            }

            return true;
        }

        public class MagentoResponse
        {
            public Boolean success { get; set; }
            public String returnMessage { get; set; }
            public String customer_id { get; set; }
            public String customer_email { get; set; }

            public MagentoResponse()
            {
                success = false;
                returnMessage = "";
                customer_id = "-1";
                customer_email = "";
            }
        }


        public class customer
        {
            String id { get; set; }
            String businessName { get; set; }
            String contactFirstName { get; set; }
            String contactLastName { get; set; }
            String contactEmail { get; set; }
            String contactPhone { get; set; }
            List<Location> locations { get; set; }
            List<Subscription> subscriptions { get; set; }
        }


        public class Location
        {
            String id { get; set; }
            String locationName { get; set; }
            String address { get; set; }
            String city { get; set; }
            String state { get; set; }
            String zip { get; set; }
            String phone { get; set; }
            List<CategoryId> categoryIds { get; set; }
            Logo logo { get; set; }
            List<Photo> photos { get; set; }
            String hours { get; set; }
            String specialOffer { get; set; }
            String yearEstablished { get; set; }
            Decimal routableLat { get; set; }
            Decimal routableLng { get; set; }
            List<Specialty> specialties { get; set; }
            List<Service> services { get; set; }
            List<Brand> brands { get; set; }
            List<Language> languages { get; set; }
            List<Keyword> keywords { get; set; }
            String isPhoneTracked { get; set; }
            String tollFreePhone { get; set; }
            String localPhone { get; set; }
        }


        public class Subscription
        {
            String offerId { get; set; }
            List<LocationId> locationIds { get; set; }
        }

        public class CategoryId
        {
            String id { get; set; }
        }

        public class Logo
        {
            String url { get; set; }
            String description { get; set; }
        }
        public class Photo
        {
            String url { get; set; }
            String description { get; set; }
        }
        public class Specialty
        {
            String description { get; set; }
        }
        public class Service
        {
            String description { get; set; }
        }
        public class Brand
        {
            String description { get; set; }
        }
        public class Language
        {
            String description { get; set; }
        }
        public class Keyword
        {
            String description { get; set; }
        }
        public class LocationId
        {
            String id { get; set; }
        }






        public static class HttpPost
        {
            public static byte[] Post(string uri, NameValueCollection pairs)
            {
                byte[] response = null;
                using (WebClient client = new WebClient())
                {
                    response = client.UploadValues(uri, pairs);
                }
                return response;
            }
        }


        public static Boolean CheckHealth()
        {
            String svn = GetRequest(baseURL + "healthy");
            DLog.Log("Yext API Health: " + svn);
            return true;
        }

        public static String GetRequest(String url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }


    }
}
