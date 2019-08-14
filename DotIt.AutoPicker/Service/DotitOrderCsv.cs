using DotIt.AutoPicker.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Service
{
    public class DotitOrderCsv
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public DotitOrderCsv(   IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
    }
        public void WriteToFile(OrderHeadModel ObjModel, string whattowrite)
        {
            var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.LogFilePath);
            if (whattowrite == "pick")
            {
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);
                PickWriter.WriteLine("Order Line " + ObjModel.TotalLines + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.PickerUserId + " at time " + ObjModel.PickDate);
                PickWriter.Dispose();
                LogWriter.WriteLine("Order Line " + ObjModel.TotalLines + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.PickerUserId + " at time " + ObjModel.PickDate);
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.PickerUserId + " at " + ObjModel.PickDate);
                QuarantineWriter.Dispose();
                LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.PickerUserId + " at " + ObjModel.PickDate);
                LogWriter.Dispose();
            }
        }
        public string[] ReadOrderProcessing()
        {

            string root = "wwwroot/OrderInProcessing.csv";
            List<string> csvlinesItems = System.IO.File.ReadLines(root).ToList();
            string[] authorsList = new string[csvlinesItems.Count];


            foreach (var _csvlinesItems in csvlinesItems)
            {
                authorsList = _csvlinesItems.Split(",");
            }

            return authorsList;
        }
        public void WriteToFileOrderProcessing(string[] Ordernum, string whattowrite)
        {

            if (whattowrite == "Processing")
            {
                var datetime = DateTime.Now;
                var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.OrderInProcessing);
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);
                foreach (var _Ordernum in Ordernum)
                {
                    PickWriter.WriteLine(_Ordernum + "," + 1 + "," + datetime);
                    LogWriter.WriteLine(_Ordernum + "," + 1 + "," + datetime);
                    //PickWriter.WriteLine ( "ordernumber " + _Ordernum + " userId " + 1 + " at time " + datetime);                    
                    //LogWriter.WriteLine(" ordernumber  " + _Ordernum + " userId " + 1 + " at time " + datetime);                   
                }
                PickWriter.Dispose();
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                //var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                //QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //QuarantineWriter.Dispose();
                //LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //LogWriter.Dispose();
            }
        }
        public void WriteToFileOrderStatus(int Ordernum, string whattowrite)
        {

            if (whattowrite == "Completed")
            {
                var datetime = DateTime.Now;
                var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.OrderStatus);
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);

                PickWriter.WriteLine(Ordernum + "," + +1 + "," + datetime + "," + "Completed");
                LogWriter.WriteLine(Ordernum + "," + 1 + "," + datetime + "," + "Completed");


                PickWriter.Dispose();
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                //var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                //QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //QuarantineWriter.Dispose();
                //LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //LogWriter.Dispose();
            }
        }

    }
}
