using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProjCstHistory
    {
        public DateTime? HistoryDate { get; set; }
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public decimal BudTotLbrHours { get; set; }
        public decimal BudTotBurHrs { get; set; }
        public decimal BudTotLbrCost { get; set; }
        public decimal BudTotBurCost { get; set; }
        public decimal BudTotSubCost { get; set; }
        public decimal BudTotMtlCost { get; set; }
        public decimal TotEstLbrHrs { get; set; }
        public decimal TotEstBurdenHrs { get; set; }
        public decimal TotEstLbrCost { get; set; }
        public decimal TotEstMtlCost { get; set; }
        public decimal TotEstSubContCost { get; set; }
        public decimal TotActLbrHrs { get; set; }
        public decimal TotActBurHrs { get; set; }
        public decimal TotActLbrCost { get; set; }
        public decimal TotActBurCost { get; set; }
        public decimal TotActSubContCost { get; set; }
        public decimal TotActMtlCost { get; set; }
        public decimal TotActMtlBurCost { get; set; }
        public decimal ManEstCtcLbrHrs { get; set; }
        public decimal ManEstCtcBurHrs { get; set; }
        public decimal ManEstCtcLbrCost { get; set; }
        public decimal ManEstCtcBurCost { get; set; }
        public decimal ManEstCtcSubConCost { get; set; }
        public decimal ManEstCtcMtlCost { get; set; }
        public decimal ManEstCtcMtlBurCost { get; set; }
        public decimal TotCtcLbrHours { get; set; }
        public decimal TotCtcBurHours { get; set; }
        public decimal TotCtcBurCost { get; set; }
        public decimal TotCtcLbrCost { get; set; }
        public decimal TotCtcSubConCost { get; set; }
        public decimal TotCtcMtlCost { get; set; }
        public decimal TotCtcMtlBurCost { get; set; }
        public decimal TotQuotLbrHrs { get; set; }
        public decimal TotQuotBurHrs { get; set; }
        public decimal TotQuotLbrCost { get; set; }
        public decimal TotQuotSubContCost { get; set; }
        public decimal TotQuotMtlCost { get; set; }
        public decimal TotQuotMtlBurCost { get; set; }
        public decimal BudTotMtlBurCost { get; set; }
        public decimal TotEstBurCost { get; set; }
        public decimal TotEstMtlBurCost { get; set; }
        public decimal TotQuotBurCost { get; set; }
        public int Seq { get; set; }
        public bool Recognition { get; set; }
        public bool PostedRecog { get; set; }
        public decimal RevenueAmt { get; set; }
        public decimal TotActOdc { get; set; }
        public decimal TotActRounding { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AutoReverse { get; set; }
        public DateTime? RevHistoryDate { get; set; }
        public int RevSeq { get; set; }
    }
}
