using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;

using DotCommon;
using DotitBllDal;


namespace EpicorDaily
{
    public static class CleanUp
    {
        public static void CleanUpRoutine()
        {
            DLog.StartModule();

            DeleteOldManifestLabels();
            DeleteOldManifestArchivalLabels();
            DeleteOldManifestAPICalls();
            DeleteOldEpicorManifestAPICalls();
            DeleteOldSwagLabels();

            DLog.EndModule();
        }


        public static void DeleteOldManifestLabels()
        {
            DLog.StartModule();

            Int32 daysToKeep = Convert.ToInt32(DataStructures.GetAppConfigSetting("keepManifestLabels", "E10BLL", DLog.isTest));
            DateTime keepTime = DateTime.Now.AddDays(daysToKeep * -1);

            if (daysToKeep < 8)
            {
                DLog.Log("Days to keep NOT GOOD" + daysToKeep.ToString(), DLog.LogLevel.Error, true);
                return;
            }

            DirectoryInfo d = new DirectoryInfo(DataStructures.GetAppConfigSetting("manifestDirectory", "E10BLL", DLog.isTest));
            FileInfo[] files = d.GetFiles("*.*");

            DLog.Log("Old Manifest Files to be deleted: " + files.Length.ToString());

            foreach (FileInfo f in files)
            {
                try
                {
                    if (f.CreationTime > keepTime) continue;
                    File.Delete(f.FullName);
                }
                catch (Exception) { }
            }

            DLog.EndModule();
        }


        public static void DeleteOldManifestArchivalLabels()
        {
            DLog.StartModule();

            Int32 daysToKeep = Convert.ToInt32(DataStructures.GetAppConfigSetting("keepManifestArchLabels", "E10BLL", DLog.isTest));
            DateTime keepTime = DateTime.Now.AddDays(daysToKeep * -1);

            if (daysToKeep < 8)
            {
                DLog.Log("Days to keep NOT GOOD: " + daysToKeep.ToString(), DLog.LogLevel.Error, true);
                return;
            }

            DirectoryInfo d = new DirectoryInfo(DataStructures.GetAppConfigSetting("manifestDirectory", "E10BLL", DLog.isTest) + @"\Archive");
            FileInfo[] files = d.GetFiles("*.*");

            DLog.Log("Old Manifest Archival Files to be deleted: " + files.Length.ToString());

            foreach (FileInfo f in files)
            {
                try
                {
                    if (f.CreationTime > keepTime) continue;
                    File.Delete(f.FullName);
                }
                catch (Exception) { }
            }

            DLog.EndModule();
        }


        public static void DeleteOldManifestAPICalls()
        {
            DLog.StartModule();

            DateTime keepTime = DateTime.Now.AddDays(-14);

            DirectoryInfo d = new DirectoryInfo(@"D:\Websites\InsiteShipV3-Dotit\CarrierXMLFile");
            FileInfo[] files = d.GetFiles("*.*");

            DLog.Log("Old Manifest Carrier files to be deleted: " + files.Length.ToString());

            foreach (FileInfo f in files)
            {
                try
                {
                    if (f.CreationTime > keepTime) continue;
                    File.Delete(f.FullName);
                }
                catch (Exception) { }
            }
        }


        public static void DeleteOldEpicorManifestAPICalls()
        {
            DLog.StartModule();

            DateTime keepTime = DateTime.Now.AddDays(-14);

            DirectoryInfo d = new DirectoryInfo(@"D:\Websites\EpicorFreightService\CarrierXMLFile");
            FileInfo[] files = d.GetFiles("*.*");

            DLog.Log("Old Epicor to Manifest api files to be deleted: " + files.Length.ToString());

            foreach (FileInfo f in files)
            {
                try
                {
                    if (f.CreationTime > keepTime) continue;
                    File.Delete(f.FullName);
                }
                catch (Exception) { }
            }
        }


        public static void DeleteOldSwagLabels()
        {
            DLog.StartModule();

            Int32 daysToKeep = 64;
            DateTime keepTime = DateTime.Now.AddDays(daysToKeep * -1);

            if (daysToKeep < 8)
            {
                DLog.Log("Days to keep NOT GOOD: " + daysToKeep.ToString(), DLog.LogLevel.Error, true);
                return;
            }

            DirectoryInfo d = new DirectoryInfo(@"C:\Dotit\MassOrders\SwagOrders\archive");
            FileInfo[] files = d.GetFiles("*.*");

            DLog.Log("Old App Swag files to be deleted: " + files.Length.ToString());

            foreach (FileInfo f in files)
            {
                try
                {
                    if (f.CreationTime > keepTime) continue;
                    File.Delete(f.FullName);
                }
                catch (Exception) { }
            }

            DLog.EndModule();
        }



    }
}
