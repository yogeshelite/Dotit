using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imfaschedule
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
        public string BookId { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal Depreciation { get; set; }
        public decimal BookValue { get; set; }
        public DateTime? PostDate { get; set; }
        public bool Posted { get; set; }
        public string ClassCode { get; set; }
        public decimal PostedDepreciation { get; set; }
        public bool Closed { get; set; }
        public bool Modified { get; set; }
        public decimal DocDepreciation { get; set; }
        public decimal DocBookValue { get; set; }
        public decimal DocPostedDepreciation { get; set; }
        public decimal Rpt1Depreciation { get; set; }
        public decimal Rpt1BookValue { get; set; }
        public decimal Rpt1PostedDepreciation { get; set; }
        public decimal Rpt2Depreciation { get; set; }
        public decimal Rpt2BookValue { get; set; }
        public decimal Rpt2PostedDepreciation { get; set; }
        public decimal Rpt3Depreciation { get; set; }
        public decimal Rpt3BookValue { get; set; }
        public decimal Rpt3PostedDepreciation { get; set; }
        public int YearNum { get; set; }
        public decimal GrantDepreciation { get; set; }
        public decimal GrantBookValue { get; set; }
        public decimal PostedGrantDepn { get; set; }
        public decimal DocGrantDepreciation { get; set; }
        public decimal DocGrantBookValue { get; set; }
        public decimal DocPostedGrantDepn { get; set; }
        public decimal Rpt1GrantDepreciation { get; set; }
        public decimal Rpt1GrantBookValue { get; set; }
        public decimal Rpt1PostedGrantDepn { get; set; }
        public decimal Rpt2GrantDepreciation { get; set; }
        public decimal Rpt2GrantBookValue { get; set; }
        public decimal Rpt2PostedGrantDepn { get; set; }
        public decimal Rpt3GrantDepreciation { get; set; }
        public decimal Rpt3GrantBookValue { get; set; }
        public decimal Rpt3PostedGrantDepn { get; set; }
        public DateTime? DepRecalcDate { get; set; }
        public int DepDetailNum { get; set; }
        public int DepYear { get; set; }
        public string DepYearSuffix { get; set; }
        public int DepPeriod { get; set; }
        public bool PeriodHoliday { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
