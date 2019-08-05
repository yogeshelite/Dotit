using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPlpartBrk
    {
        public string Company { get; set; }
        public decimal DiscountPercent { get; set; }
        public string ListCode { get; set; }
        public string PartNum { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Uomcode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbListCode { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbUomcode { get; set; }
        public decimal GlbQuantity { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPlpartBrk { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
