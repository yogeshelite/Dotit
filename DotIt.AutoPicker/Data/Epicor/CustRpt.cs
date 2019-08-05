using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustRpt
    {
        public string CustReportId { get; set; }
        public string Description { get; set; }
        public string RblibraryFileName { get; set; }
        public string ReportName { get; set; }
        public bool ChangeRptFilter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
