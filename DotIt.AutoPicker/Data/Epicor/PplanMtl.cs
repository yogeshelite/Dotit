using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PplanMtl
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public decimal QtyPer { get; set; }
        public DateTime? ReqDate { get; set; }
        public bool BuyIt { get; set; }
        public bool Direct { get; set; }
        public string WarehouseCode { get; set; }
        public decimal RequiredQty { get; set; }
        public decimal AvailableQty { get; set; }
        public decimal ConsumedQty { get; set; }
        public decimal ShortageQty { get; set; }
        public bool Shortage { get; set; }
        public int PriorityFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
