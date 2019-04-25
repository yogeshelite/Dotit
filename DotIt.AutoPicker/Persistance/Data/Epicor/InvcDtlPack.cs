using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InvcDtlPack
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string LotNum { get; set; }
        public decimal OurOrderQty { get; set; }
        public decimal OurShipQty { get; set; }
        public decimal SellingOrderQty { get; set; }
        public decimal SellingShipQty { get; set; }
        public decimal MxsellingShipQty { get; set; }
        public decimal MtlUnitCost { get; set; }
        public decimal LbrUnitCost { get; set; }
        public decimal BurUnitCost { get; set; }
        public decimal SubUnitCost { get; set; }
        public decimal MtlBurUnitCost { get; set; }
        public decimal JcmtlUnitCost { get; set; }
        public decimal JclbrUnitCost { get; set; }
        public decimal JcburUnitCost { get; set; }
        public decimal JcsubUnitCost { get; set; }
        public decimal JcmtlBurUnitCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual InvcDtl InvcDtl { get; set; }
        public virtual ShipDtl ShipDtl { get; set; }
    }
}
