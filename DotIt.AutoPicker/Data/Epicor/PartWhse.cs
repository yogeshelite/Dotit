using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartWhse
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public decimal DemandQty { get; set; }
        public decimal ReservedQty { get; set; }
        public decimal AllocatedQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal PickedQty { get; set; }
        public DateTime? CountedDate { get; set; }
        public decimal OnHandQty { get; set; }
        public decimal NonNettableQty { get; set; }
        public decimal BuyToOrderQty { get; set; }
        public decimal SalesDemandQty { get; set; }
        public decimal SalesReservedQty { get; set; }
        public decimal SalesAllocatedQty { get; set; }
        public decimal SalesPickingQty { get; set; }
        public decimal SalesPickedQty { get; set; }
        public decimal JobDemandQty { get; set; }
        public decimal JobReservedQty { get; set; }
        public decimal JobAllocatedQty { get; set; }
        public decimal JobPickingQty { get; set; }
        public decimal JobPickedQty { get; set; }
        public decimal UnfirmJobDemandQty { get; set; }
        public decimal TfordDemandQty { get; set; }
        public decimal TfordReservedQty { get; set; }
        public decimal TfordAllocatedQty { get; set; }
        public decimal TfordPickingQty { get; set; }
        public decimal TfordPickedQty { get; set; }
        public string Kbcode { get; set; }
        public decimal MinimumQty { get; set; }
        public decimal MaximumQty { get; set; }
        public decimal SafetyQty { get; set; }
        public int Kbponum { get; set; }
        public int Kbpoline { get; set; }
        public string KbwarehouseCode { get; set; }
        public string KbbinNum { get; set; }
        public string Kbplant { get; set; }
        public decimal Kbqty { get; set; }
        public decimal PcntTolerance { get; set; }
        public bool CalcPcnt { get; set; }
        public bool CalcQty { get; set; }
        public bool CalcValue { get; set; }
        public decimal QtyAdjTolerance { get; set; }
        public bool CalcQtyAdj { get; set; }
        public string MinAbc { get; set; }
        public string SystemAbc { get; set; }
        public bool ManualAbc { get; set; }
        public DateTime? LastCcdate { get; set; }
        public bool OvrrideCountFreq { get; set; }
        public int CountFreq { get; set; }
        public decimal QtyTolerance { get; set; }
        public decimal ValueTolerance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
