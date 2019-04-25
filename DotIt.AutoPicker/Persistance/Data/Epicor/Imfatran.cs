using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imfatran
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
        public string AssetRegId { get; set; }
        public int DetailNum { get; set; }
        public int SeqNum { get; set; }
        public int AssetSeq { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal Depreciation { get; set; }
        public decimal BookValue { get; set; }
        public DateTime? PostDate { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public bool Posted { get; set; }
        public string ClassCode { get; set; }
        public string PostedBy { get; set; }
        public decimal PostValue { get; set; }
        public bool Closed { get; set; }
        public bool Modified { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string BookId { get; set; }
        public decimal DocDepreciation { get; set; }
        public decimal DocBookValue { get; set; }
        public decimal DocPostValue { get; set; }
        public decimal Rpt1Depreciation { get; set; }
        public decimal Rpt1BookValue { get; set; }
        public decimal Rpt1PostValue { get; set; }
        public decimal Rpt2Depreciation { get; set; }
        public decimal Rpt2BookValue { get; set; }
        public decimal Rpt2PostValue { get; set; }
        public decimal Rpt3Depreciation { get; set; }
        public decimal Rpt3BookValue { get; set; }
        public decimal Rpt3PostValue { get; set; }
        public int YearNum { get; set; }
        public decimal GrantDepreciation { get; set; }
        public decimal GrantBookValue { get; set; }
        public decimal PostGrantValue { get; set; }
        public decimal DocGrantDepreciation { get; set; }
        public decimal DocGrantBookValue { get; set; }
        public decimal DocPostGrantValue { get; set; }
        public decimal Rpt1GrantDepreciation { get; set; }
        public decimal Rpt1GrantBookValue { get; set; }
        public decimal Rpt1PostGrantValue { get; set; }
        public decimal Rpt2GrantDepreciation { get; set; }
        public decimal Rpt2GrantBookValue { get; set; }
        public decimal Rpt2PostGrantValue { get; set; }
        public decimal Rpt3GrantDepreciation { get; set; }
        public decimal Rpt3GrantBookValue { get; set; }
        public decimal Rpt3PostGrantValue { get; set; }
        public DateTime? DepRecalcDate { get; set; }
        public string Abtuid { get; set; }
        public int DepDetailNum { get; set; }
        public int DepYear { get; set; }
        public string DepYearSuffix { get; set; }
        public int DepPeriod { get; set; }
        public bool PeriodHoliday { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int TranType { get; set; }
        public bool HdrCostRecorded { get; set; }
        public string RecordedRegList { get; set; }
        public int SrcTranNum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
