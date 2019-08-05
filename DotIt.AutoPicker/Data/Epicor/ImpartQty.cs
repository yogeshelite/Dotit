using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartQty
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public string DimCode { get; set; }
        public decimal DemandQty { get; set; }
        public decimal ReservedQty { get; set; }
        public decimal AllocatedQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal PickedQty { get; set; }
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
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
