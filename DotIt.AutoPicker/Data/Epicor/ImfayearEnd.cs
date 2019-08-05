using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImfayearEnd
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
        public int AssetSeq { get; set; }
        public int FiscalYear { get; set; }
        public bool Depreciate { get; set; }
        public string GroupCode { get; set; }
        public string SpreadCode { get; set; }
        public string ClassCode { get; set; }
        public string DepreciationMethod { get; set; }
        public string LifeModifier { get; set; }
        public decimal DepnPercent { get; set; }
        public int AssetLife { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public DateTime? CommissionedDate { get; set; }
        public decimal OverideCost { get; set; }
        public decimal ResidualValue { get; set; }
        public decimal ReplaceValue { get; set; }
        public decimal CyopeningCost { get; set; }
        public decimal CyopeningDepn { get; set; }
        public decimal CyopeningBookValue { get; set; }
        public decimal CyadditionCost { get; set; }
        public decimal CyadditionPrevYearDepn { get; set; }
        public decimal CyadditionCurrYearDepn { get; set; }
        public decimal CyadditionBookvalue { get; set; }
        public decimal CydisposalCost { get; set; }
        public decimal CydisposalPrevYearDepn { get; set; }
        public decimal CydisposalCurrYearDepn { get; set; }
        public decimal CydisposalBookvalue { get; set; }
        public decimal CydisposalProceeds { get; set; }
        public decimal CydisposalProfit { get; set; }
        public decimal CurrentCostvalue { get; set; }
        public decimal CurrentPrevYearDepn { get; set; }
        public decimal CurrentPostedDepn { get; set; }
        public decimal CurrentBookvalue { get; set; }
        public decimal CurrentUnpostedDepn { get; set; }
        public decimal CurrentYebookvalue { get; set; }
        public decimal LyopeningCost { get; set; }
        public decimal LyopeningDepn { get; set; }
        public decimal LyopeningBookValue { get; set; }
        public decimal LyadditionCost { get; set; }
        public decimal LyadditionPrevYearDepn { get; set; }
        public decimal LyadditionCurrYearDepn { get; set; }
        public decimal LyadditionBookvalue { get; set; }
        public decimal LydisposalCost { get; set; }
        public decimal LydisposalPrevYearDepn { get; set; }
        public decimal LydisposalCurrYearDepn { get; set; }
        public decimal LydisposalBookvalue { get; set; }
        public decimal LydisposalProceeds { get; set; }
        public decimal LydisposalProfit { get; set; }
        public string AssetMethod { get; set; }
        public decimal Acquire { get; set; }
        public decimal BookValue { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
