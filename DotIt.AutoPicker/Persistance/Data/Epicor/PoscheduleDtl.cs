using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PoscheduleDtl
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public int ContractPonum { get; set; }
        public int ContractPoline { get; set; }
        public int ContractRev { get; set; }
        public int ContractPorelNum { get; set; }
        public string LastPackSlip { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public decimal LastReceiptOurQty { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int WeekNum { get; set; }
        public int WeekYear { get; set; }
        public decimal CurrentOurQty { get; set; }
        public decimal SuggestedOurQty { get; set; }
        public decimal AdjustedOurQty { get; set; }
        public decimal ProposedOurQty { get; set; }
        public string OurQtyUom { get; set; }
        public string PosuggLastPackSlip { get; set; }
        public decimal PurchasingFactor { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public string DevChar01 { get; set; }
        public string DevChar02 { get; set; }
        public string DevChar03 { get; set; }
        public string DevChar04 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
