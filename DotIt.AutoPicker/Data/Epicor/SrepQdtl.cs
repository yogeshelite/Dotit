using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SrepQdtl
    {
        public string Company { get; set; }
        public string SalesRepCode { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal QuotaAmt { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
