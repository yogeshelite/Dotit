using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Baqreport
    {
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string Description { get; set; }
        public string ReportTitle { get; set; }
        public string FormTitle { get; set; }
        public string ExportId { get; set; }
        public bool SystemFlag { get; set; }
        public bool Completed { get; set; }
        public bool GlobalReport { get; set; }
        public bool IsCrystalReport { get; set; }
        public string ReportId { get; set; }
        public string CrystalReportName { get; set; }
        public string Cgccode { get; set; }
        public string SsrsreportName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
