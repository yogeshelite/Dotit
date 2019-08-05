using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcBatchSched
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int SchedNum { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string BookId { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? ApplyDateRev { get; set; }
        public DateTime? SchedDate { get; set; }
        public int AllocStatus { get; set; }
        public DateTime? LastSchedDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CloseFiscalPeriod { get; set; }
    }
}
