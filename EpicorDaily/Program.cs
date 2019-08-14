using System;
using System.Collections.Generic;
using System.Linq;

//using Erp.BO;
//using Erp.Proxy.BO;
using Ice.Lib.Framework;
using Ice.Core;

using DotCommon;
//using DotitBllDal;
using log4net.Util;
using log4net;

namespace EpicorDaily
{

    class Program
    {
        static void Main(String[] args)
        {
            //DLog.StartProgram("EpicorDaily", DotConst.PROD_Environment);
           
            DLog.StartProgram("EpicorDaily", DotConst.TEST_Environment);


            try
            {
               // Session session = null;// E10.GetE10Session();
                //DLog.Log("Session established: " + session.SessionID);

                if (DLog.isTest)
                {
                    DLog.Log("Headed down the test route!");

                    //session.Dispose();
                    //return;
                }


                //Yext.OrderProcessing(session);

                try
                {
                    //WebOrders.OrderAdjustments(session);
                    //AFS.ProcessNewAFSLineItems(session);
                    //Yext.OrderProcessing(session);

                    // NCCOEDIOrderSubmission ncco = new NCCOEDIOrderSubmission();
                    // ncco.EDIOrderSubmission();
                    PickerJob.SyncEpicorPickers();
                    PickerJob.SyncEpicorOrders();

                    if (ProcessOnceADay())
                    {
                      
                       
                        //  PunchhSwag.CheckSWAGOrders(session);
                        //  Notifications.SendShippingNotification();
                        // JobManagement.ManageJobs();
                        // CleanUp.CleanUpRoutine();


                        //OutstandingBalance.GenerateEmailNotifications();
                        //EdiConfirmationMessages.Return945ShippingVerification();
                    }
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex);
                }

                //session.Dispose();
            }
            catch (Exception ex)
            {
                DLog.Log("Issues creating session: " + ex.Message, DLog.LogLevel.Error);
                // throw;
            }
            DLog.EndModule();
        }


        public static Boolean ProcessOnceADay()
        {
            TimeSpan start = new TimeSpan(22, 58, 0);
            TimeSpan end = new TimeSpan(23, 2, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end)) return true;
            return false;
        }
    }
}
