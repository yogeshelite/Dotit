using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FaperDep
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public string AssetRegId { get; set; }
        public int YearNum { get; set; }
        public int PerNum { get; set; }
        public int AssetSeq { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal Depreciation { get; set; }
        public decimal PostedDep { get; set; }
        public decimal BookValue { get; set; }
        public decimal GrantDep { get; set; }
        public decimal PostedGrantDep { get; set; }
        public decimal DocDepreciation { get; set; }
        public decimal DocPostedDep { get; set; }
        public decimal DocBookValue { get; set; }
        public decimal DocGrantDep { get; set; }
        public decimal DocPostedGrantDep { get; set; }
        public decimal Rpt1Depreciation { get; set; }
        public decimal Rpt1PostedDep { get; set; }
        public decimal Rpt1BookValue { get; set; }
        public decimal Rpt1GrantDep { get; set; }
        public decimal Rpt1PostedGrantDep { get; set; }
        public decimal Rpt2Depreciation { get; set; }
        public decimal Rpt2PostedDep { get; set; }
        public decimal Rpt2BookValue { get; set; }
        public decimal Rpt2GrantDep { get; set; }
        public decimal Rpt2PostedGrantDep { get; set; }
        public decimal Rpt3Depreciation { get; set; }
        public decimal Rpt3PostedDep { get; set; }
        public decimal Rpt3BookValue { get; set; }
        public decimal Rpt3GrantDep { get; set; }
        public decimal Rpt3PostedGrantDep { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string RateGrpCode { get; set; }
        public string AssetMethod { get; set; }
        public string BookId { get; set; }
        public bool MethodSwitched { get; set; }
        public string AltAssetMethod { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
