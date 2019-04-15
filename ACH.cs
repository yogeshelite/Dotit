using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

using DotCommon;
//using DotitBllDal;

namespace EpicorDaily
{
    class ACH
    {


        #region//20190404- Amit : Property declare to call Epicor Api Caller 
        public static EpicorBusinessApi _EpicorBusinessApi { get; set; }
        #endregion

        public static void GenerateNACHA()
        {
            DLog.StartModule();


            String filePath = @"\\DotitE102\ACH\"; //DataStructures.GetAppConfigSetting("NCCOEDIFilePath", "E10BLL", DLog.isTest);
            String filePathHistory = filePath + @"History\";

            DLog.Log("File path for NCCO orders: " + filePath);

            DirectoryInfo di = new DirectoryInfo(filePath);
            FileInfo[] files = di.GetFiles("*.txt");

            if (files.Length <= 0)
            {
                DLog.Log("There are no files to be processed at this time. ");
                return;
            }

            DLog.Log("There are " + files.Length.ToString() + " files to be processed");

            String newFileName = "abc.ach";
            #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 
            //EpicorE10DataContext cs = new EpicorE10DataContext(DLog.CS);
            #endregion
            foreach (FileInfo f in files)
            {
                if (!File.Exists(f.FullName))
                {
                    DLog.Log("ACH file to process does not exist: " + f.FullName, DLog.LogLevel.Error, true);
                    continue;
                }

                try
                {
                    List<String> opACH = new List<String>();
                    String[] lines = File.ReadAllLines(f.FullName);

                    newFileName = f.Name.Replace(".txt", ".ach");

                    //opACH.Add("101 0910000223462860779"+ dtNow.ToString("yyMMddhhmm") + "A094101US BANK                DOT IT RESTAURANT FULFI");
                    //opACH.Add("5200DOT IT RESTAURAN                    3462860779CCDTRADE PAY       " + dtNow.ToString("yyMMdd") + "   1091000020000001");

                  
                    foreach (String line in lines)
                    {
                        String s = line.Substring(0, 1);
                        String newLine = line;
                        //if (s == "1" || s == "5")
                        //{
                        //    DLog.Log("Line: " + line);
                        //    newLine = line.Replace("46-2860779", "3462860779");
                        //}
                        //if (s == "8")
                        //{
                        //    DLog.Log("Line: " + line);
                        //    newLine = line.Replace("462860779 ", "3462860779");
                        //}
                        if (line.Substring(0, 3) == "622")
                        {
                            if (String.IsNullOrWhiteSpace(line.Substring(3, 9)))
                            {
                                String sAcctNumb = line.Substring(12, 17).Trim();
                                DLog.Log("sAcctNumb: " + sAcctNumb);

                                try
                                {

                                    #region//20190404- Amit : Remove DotitBal Referrence and Get Data From Epicor Api 
                                    //String routingNumber = (from vb in cs.VendBanks where vb.BankAcctNumber == sAcctNumb select vb.SwiftNum).Single();
                                    String routingNumber = _EpicorBusinessApi.GetVendorBank(sAcctNumb).Select(fld=>fld.SwiftNum).Single();
                                    #endregion
                                    newLine = line.Substring(0, 3) + routingNumber.PadRight(9, ' ') + line.Substring(12);
                                }
                                catch (Exception ex)
                                {
                                    DLog.LogErr(ex);
                                    newLine = line;
                                }
                            }
                            else
                            {
                                DLog.Log("routing number is not blank: " + line);
                            }
                        }
                        opACH.Add(newLine);
                    }

                    File.WriteAllLines(@"\\DotitE102\ach\" + newFileName, opACH.ToArray());
                }
                catch (Exception ex)
                {
                    DLog.LogErr(ex);
                }


                //opACH.Add("820000003404141735750000000000000000101452463462860779                         091000020000001");
                //opACH.Add("9000001000004000000340414173575000000000000000010145246                                       ");



                //if (DLog.isTest)
                //{
                //    File.Copy(f.FullName, filePathHistory + f.Name);          //  Simply to allow repetitve tests without having to rename original file
                //}
                //else
                //{
                //    File.Move(f.FullName, filePathHistory + f.Name);
                //}
            }

        }

       
    }
}
