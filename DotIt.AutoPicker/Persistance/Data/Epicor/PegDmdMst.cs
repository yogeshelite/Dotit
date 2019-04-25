using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PegDmdMst
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public int DemandSeq { get; set; }
        public string DemandOrdNum { get; set; }
        public int DemandOrdLine { get; set; }
        public string DemandOrdRel { get; set; }
        public string PartNum { get; set; }
        public string DemandType { get; set; }
        public DateTime? DemandDate { get; set; }
        public decimal DemandQty { get; set; }
        public string DemandQtyUom { get; set; }
        public string WarehouseCode { get; set; }
        public decimal PeggedQty { get; set; }
        public string PeggedQtyUom { get; set; }
        public bool KeepLink { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
    }
}
