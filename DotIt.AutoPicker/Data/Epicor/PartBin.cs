using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartBin
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public decimal OnhandQty { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
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
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
        public bool SendToFsa { get; set; }
    }
}
