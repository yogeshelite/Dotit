using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imfaimpairment
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int ImpairNum { get; set; }
        public string Description { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool ReadyToPost { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostDate { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public decimal ImpairmentCost { get; set; }
        public decimal DocImpairmentCost { get; set; }
        public decimal Rpt1ImpairmentCost { get; set; }
        public decimal Rpt2ImpairmentCost { get; set; }
        public decimal Rpt3ImpairmentCost { get; set; }
        public string PostedBy { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool HdrCostRecorded { get; set; }
        public string RecordedRegList { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
