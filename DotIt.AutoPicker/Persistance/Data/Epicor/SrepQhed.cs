using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SrepQhed
    {
        public string Company { get; set; }
        public string SalesRepCode { get; set; }
        public int FiscalYear { get; set; }
        public decimal TotalQuotaAmt { get; set; }
        public string QuotaPerCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
