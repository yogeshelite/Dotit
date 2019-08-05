using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PegLink
    {
        public string Company { get; set; }
        public int PegNum { get; set; }
        public decimal PeggedQty { get; set; }
        public string PeggedQtyUom { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public int DemandSeq { get; set; }
        public int SupplySeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
    }
}
