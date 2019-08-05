using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpplanQty
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
