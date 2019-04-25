using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtfshipDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int Packages { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string RevisionNum { get; set; }
        public string ShipComment { get; set; }
        public bool ShipCmpl { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public bool UpdatedInventory { get; set; }
        public string NetWeightUom { get; set; }
        public string LotNum { get; set; }
        public decimal TotalNetWeight { get; set; }
        public string WipwarehouseCode { get; set; }
        public string WipbinNum { get; set; }
        public int TfordLine { get; set; }
        public decimal OurStockQty { get; set; }
        public decimal OurStockShippedQty { get; set; }
        public DateTime? Requestdate { get; set; }
        public string TfordNum { get; set; }
        public string TflineNum { get; set; }
        public decimal DiscountPercent { get; set; }
        public string PricePerCode { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal ExtPrice { get; set; }
        public decimal DocExtPrice { get; set; }
        public decimal Rpt1ExtPrice { get; set; }
        public decimal Rpt2ExtPrice { get; set; }
        public decimal Rpt3ExtPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public decimal PickedAutoAllocatedQty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
        public decimal AllocatedShippedQty { get; set; }
    }
}
