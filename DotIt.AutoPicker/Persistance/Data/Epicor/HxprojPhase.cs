using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxprojPhase
    {
        public int Revision { get; set; }
        public decimal ActTotBurCost { get; set; }
        public decimal ActTotBurHrs { get; set; }
        public decimal ActTotLbrCost { get; set; }
        public decimal ActTotLbrHrs { get; set; }
        public decimal ActTotMtlBurCost { get; set; }
        public decimal ActTotMtlCost { get; set; }
        public decimal ActTotOdccost { get; set; }
        public decimal ActTotSubContCost { get; set; }
        public decimal BudTotBurCost { get; set; }
        public decimal BudTotBurHrs { get; set; }
        public decimal BudTotLbrCost { get; set; }
        public decimal BudTotLbrHrs { get; set; }
        public decimal BudTotMtlBurCost { get; set; }
        public decimal BudTotMtlCost { get; set; }
        public decimal BudTotOdccost { get; set; }
        public decimal BudTotSubContCost { get; set; }
        public string Company { get; set; }
        public DateTime? DateComplete { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal Duration { get; set; }
        public string DurationType { get; set; }
        public decimal EstTotBurCost { get; set; }
        public decimal EstTotBurHrs { get; set; }
        public decimal EstTotLbrCost { get; set; }
        public decimal EstTotLbrHrs { get; set; }
        public decimal EstTotMtlBurCost { get; set; }
        public decimal EstTotMtlCost { get; set; }
        public decimal EstTotOdccost { get; set; }
        public decimal EstTotSubContCost { get; set; }
        public int Level { get; set; }
        public decimal ManEstCtcBurCost { get; set; }
        public decimal ManEstCtcBurHrs { get; set; }
        public decimal ManEstCtcLbrCost { get; set; }
        public decimal ManEstCtcLbrHrs { get; set; }
        public decimal ManEstCtcMtlBurCost { get; set; }
        public decimal ManEstCtcMtlCost { get; set; }
        public decimal ManEstCtcodccost { get; set; }
        public decimal ManEstCtcSubConCost { get; set; }
        public string MeasuredWorkId { get; set; }
        public string Msppredecessor { get; set; }
        public string MsptaskId { get; set; }
        public string ParentPhase { get; set; }
        public decimal PercentComplete { get; set; }
        public string PhaseId { get; set; }
        public string PhaseStatus { get; set; }
        public string ProjectId { get; set; }
        public bool RollChildBud { get; set; }
        public bool RollChildMan { get; set; }
        public int SortSeq { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal TotCtcBurCost { get; set; }
        public decimal TotCtcBurHrs { get; set; }
        public decimal TotCtcLbrCost { get; set; }
        public decimal TotCtcLbrHrs { get; set; }
        public decimal TotCtcMtlBurCost { get; set; }
        public decimal TotCtcMtlCost { get; set; }
        public decimal TotCtcodccost { get; set; }
        public decimal TotCtcSubConCost { get; set; }
        public decimal TotQuotBurCost { get; set; }
        public decimal TotQuotBurHrs { get; set; }
        public decimal TotQuotLbrCost { get; set; }
        public decimal TotQuotLbrHrs { get; set; }
        public decimal TotQuotMtlBurCost { get; set; }
        public decimal TotQuotMtlCost { get; set; }
        public decimal TotQuotOdccost { get; set; }
        public decimal TotQuotSubContCost { get; set; }
        public string UserMapData { get; set; }
        public string WbsjobNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string InvMethod { get; set; }
        public string RevMethod { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public bool WasRecInvoiced { get; set; }
    }
}
