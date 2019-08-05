using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PplanQty
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string ContractId { get; set; }
        public string PartDescription { get; set; }
        public decimal OnhandQty { get; set; }
        public decimal NonNettableQty { get; set; }
        public decimal SalesDemandQty { get; set; }
        public decimal SalesReservedQty { get; set; }
        public decimal SalesPickingQty { get; set; }
        public decimal SalesPickedQty { get; set; }
        public decimal JobDemandQty { get; set; }
        public decimal JobReservedQty { get; set; }
        public decimal JobUnfirmDemandQty { get; set; }
        public decimal AvailableQty { get; set; }
        public decimal ConsumedQty { get; set; }
        public decimal ShortageQty { get; set; }
        public bool Shortage { get; set; }
        public string ShortJobNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
