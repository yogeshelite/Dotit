using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImttSupply
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SupplyType { get; set; }
        public string Source { get; set; }
        public DateTime? ReqDue { get; set; }
        public decimal Wipqty { get; set; }
        public bool Rls { get; set; }
        public bool Cmp { get; set; }
        public decimal ProdQty { get; set; }
        public decimal Relieved { get; set; }
        public string JobNum { get; set; }
        public string WarehouseCode { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string TargetJobNum { get; set; }
        public int TargetAssemblySeq { get; set; }
        public int TargetMtlSeq { get; set; }
        public int SupplyNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
