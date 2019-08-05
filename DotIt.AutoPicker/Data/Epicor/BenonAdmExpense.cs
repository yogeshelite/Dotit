using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BenonAdmExpense
    {
        public string Company { get; set; }
        public string Naeid { get; set; }
        public string Description { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public decimal Naepercent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
