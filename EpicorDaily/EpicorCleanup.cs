using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;

using Erp.BO;
using Erp.Proxy.BO;
using Ice.Core;
using Ice.Lib.Framework;

using DotCommon;
using DotitBllDal;


namespace EpicorDaily
{
    static class EpicorCleanup
    {
        //public static String DS = ConfigurationManager.ConnectionStrings["DotitExt"].ConnectionString;
        //public static String CS = ConfigurationManager.ConnectionStrings["Epicor"].ConnectionString;
        //static DotitBllDal.DotitExtDataContext dd = new DotitBllDal.DotitExtDataContext(DS);
        //static EpicorE10DataContext db = new EpicorE10DataContext(CS);

        public static void DoEpicorCleanup([CallerMemberName]string memberName = "")
        {
            DLog.StartModule();

            String configFile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + DataStructures.GetAppConfigSetting("E10ConfigFile", "E10BLL", DLog.isTest);
            String epicorUser = DataStructures.GetAppConfigSetting("E10User", "E10BLL", DLog.isTest);
            String epicorPass = DataStructures.GetAppConfigSetting("E10Pass", "E10BLL", DLog.isTest);

            using (var session = new Session(epicorUser, epicorPass, Ice.Core.Session.LicenseType.WebService, configFile))
            {
                switch (memberName)
                {
                    case "CheckPacksWOLines":
                        DeletePacksWOLines(session);
                        break;
                    default:
                        break;
                }
            }

            DLog.EndModule();
        }


        private static void DeletePacksWOLines(Session session)
        {
            EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);

            DLog.StartModule();
            Int32 currentPack = 0;

            using (var custShipBO = WCFServiceSupport.CreateImpl<CustShipImpl>(session, CustShipImpl.UriPath))
            {
                DateTime dt = DateTime.Now.AddDays(-1);     //  Only delete if older than a day
                List<ShipHead> rsShipHeads = (from sh in cs.ShipHeads
                                              where !cs.ShipDtls.Any(f => f.PackNum == sh.PackNum) && sh.Voided == false && sh.TrackingNumber == ""
                                              select sh).ToList();

                foreach (ShipHead shs in rsShipHeads)
                {
                    currentPack = shs.PackNum;
                    try
                    {
                        CustShipDataSet custShipDS = custShipBO.GetByID(shs.PackNum);
                        CustShipDataSet.ShipHeadRow shipHeadRow = custShipDS.ShipHead[0];
                        shipHeadRow.RowMod = "D";
                        custShipBO.Update(custShipDS);
                    }
                    catch (Exception ex)
                    {
                        DLog.Log("Issues with packNum: " + currentPack.ToString() + " " + ex.ToString());
                    }
                }
                EpicorCleanup.DoEpicorCleanup();
            }

            DLog.EndModule();
        }
    }
}
