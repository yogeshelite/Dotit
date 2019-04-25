using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PegSupMst
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public int SupplySeq { get; set; }
        public string SupplyOrdNum { get; set; }
        public int SupplyOrdLine { get; set; }
        public string SupplyOrdRel { get; set; }
        public string PartNum { get; set; }
        public string SupplyType { get; set; }
        public DateTime? SupplyDate { get; set; }
        public decimal SupplyQty { get; set; }
        public string SupplyQtyUom { get; set; }
        public decimal PeggedQty { get; set; }
        public string PeggedQtyUom { get; set; }
        public string WarehouseCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
    }
}
