using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Nlicpreport
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Description { get; set; }
        public string RangeType { get; set; }
        public string RangeOption { get; set; }
        public int FiscalYear { get; set; }
        public int StartFiscalPeriod { get; set; }
        public int EndFiscalPeriod { get; set; }
        public string FiscalYearSuffix { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool Test { get; set; }
        public bool IncludeBackItems { get; set; }
        public DateTime? StartDateBackItems { get; set; }
        public bool Posted { get; set; }
        public bool Submitted { get; set; }
        public int EftheadUid { get; set; }
        public string LastExportedBy { get; set; }
        public DateTime? LastExportedDate { get; set; }
        public string LastSentBy { get; set; }
        public DateTime? LastSentDate { get; set; }
        public int SentStatus { get; set; }
        public string SentErrorMessage { get; set; }
        public string OutputFile { get; set; }
        public string CurrencyCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
