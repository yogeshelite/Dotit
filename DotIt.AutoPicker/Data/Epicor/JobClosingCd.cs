using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobClosingCd
    {
        public string Company { get; set; }
        public string JobClosingCode { get; set; }
        public string Description { get; set; }
        public bool JobCompletion { get; set; }
        public bool JobClosing { get; set; }
        public bool JobCompletionDefault { get; set; }
        public bool JobClosingDefault { get; set; }
        public int MtlQtyPercent { get; set; }
        public int MtlCostPercent { get; set; }
        public int OprQtyPercent { get; set; }
        public int OprCostPercent { get; set; }
        public int SubQtyPercent { get; set; }
        public int SubCostPercent { get; set; }
        public int MtlQtyOverPercent { get; set; }
        public int MtlCostOverPercent { get; set; }
        public int OprQtyOverPercent { get; set; }
        public int OprCostOverPercent { get; set; }
        public int SubQtyOverPercent { get; set; }
        public int SubCostOverPercent { get; set; }
        public decimal JobCostAmount { get; set; }
        public decimal JobCostOverAmount { get; set; }
        public bool Backflush { get; set; }
        public bool PendingInspection { get; set; }
        public bool MultiplePlants { get; set; }
        public bool ExJobsNotShipComplete { get; set; }
        public bool ExJobsNotShipClosed { get; set; }
        public bool IgnoreCompleted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
