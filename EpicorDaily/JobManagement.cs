using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotCommon;
using DotitBllDal;

namespace EpicorDaily
{
    public static class JobManagement
    {
        public static void ManageJobs()
        {
            DLog.StartModule();


            //MossDex.CalculatePriceActiveJobs();
            //MossDex.CalculateNumberOfOrdersActiveJobs();
            //UpdateUPSDelivery();
            UpdatePackOutNumbers();
            JobCompelete();
            //CheckFlags();
        }


        private static void UpdateUPSDelivery()
        {
            DLog.StartModule();

            try
            {
                DotitExtDataContext db = new DotitExtDataContext(DLog.DS);

                var rsJobs = from j in db.JOBs where j.ISACTIVE && j.SHIPVIA.Substring(0, 1).ToUpper() == "U" select j;

                foreach (JOB job in rsJobs)
                {
                    MossDex.ReturnTrackingUpdateByJob(job.JOBID, true);
                }
            }
            catch (Exception ex) { DLog.LogErr(ex); }

        }


        public static void UpdatePackOutNumbers()
        {
            DLog.StartModule();

            try
            {
                DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);
                EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

                var rsJobors = from j in ds.JOBs
                               join jr in ds.JOBORDERRELEASEs on j.JOBID equals jr.JOBID
                               where j.ISACTIVE && jr.PACKNUMBERS == ""
                               select jr;

                foreach (JOBORDERRELEASE jor in rsJobors)
                {
                    try
                    {
                        String[] rsE10Orders = (from sd in cs.ShipDtls where sd.OrderNum == jor.E10ORDERNUM group sd.PackNum by sd.PackNum into g select g.Key.ToString()).ToArray();
                        jor.PACKNUMBERS = String.Join(";", rsE10Orders);
                    }
                    catch (Exception ex) { DLog.LogErr(ex); }
                }
                ds.SubmitChanges();

            }
            catch (Exception ex) { DLog.LogErr(ex); }

        }


        private static void JobCompelete()
        {
            DLog.StartModule();

            try
            {
                DotitExtDataContext ds = new DotitExtDataContext(DLog.DS);

                List<JOB> rsActiveJobs = (from j in ds.JOBs where j.ISACTIVE select j).ToList<JOB>();

                foreach (JOB job in rsActiveJobs)
                {
                    var rsJobors = from jor in ds.JOBORDERRELEASEs where jor.JOBID == job.JOBID && jor.PACKNUMBERS == "" select jor;

                    if (rsJobors.Count() == 0) DexJobs.UpdateJob(job.JOBID, false, DataStructures.JobFlagType.Active);
                }
            }
            catch (Exception ex) { DLog.LogErr(ex); }


        }


        private static void CheckFlags()
        {
            try
            {
                DotitExtDataContext db = new DotitExtDataContext();
                Boolean anyJobWeights = true;
                Boolean anyJobRates = true;

                var rsJobs = from j in db.JOBs where j.ISACTIVE select j;

                foreach (JOB job in rsJobs)
                {
                    Boolean anyOrdRelWeights = true;
                    Boolean anyOrdRelRates = true;

                    var rsJobors = from jor in db.JOBORDERRELEASEs where jor.JOBID == job.JOBID select jor;

                    foreach (JOBORDERRELEASE jobOrd in rsJobors)
                    {
                        var rsBoxes = from b in db.JOBORDBOXes where b.JOBORID == jobOrd.JOBORID select b;

                        foreach (JOBORDBOX box in rsBoxes)
                        {
                            if (box.BOXWEIGHT <= 0.0m)
                            {
                                anyOrdRelWeights = false;
                                anyJobWeights = false;
                            }
                            //if (box)
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                DLog.LogErr(ex);
            }
        }

    }
}
