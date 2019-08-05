using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartBinDeferred
    {
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public decimal OnhandQty { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public int DeferredSeq { get; set; }
        public decimal AllocatedQty { get; set; }
        public decimal SalesAllocatedQty { get; set; }
        public decimal SalesPickingQty { get; set; }
        public decimal SalesPickedQty { get; set; }
        public decimal JobAllocatedQty { get; set; }
        public decimal JobPickingQty { get; set; }
        public decimal JobPickedQty { get; set; }
        public decimal TfordAllocatedQty { get; set; }
        public decimal TfordPickingQty { get; set; }
        public decimal TfordPickedQty { get; set; }
        public decimal ShippingQty { get; set; }
        public decimal PackedQty { get; set; }
        public string SessionId { get; set; }
        public string Source { get; set; }
        public string SessionPlantId { get; set; }
        public string SessionUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
    }
}
