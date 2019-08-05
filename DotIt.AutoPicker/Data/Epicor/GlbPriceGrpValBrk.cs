using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPriceGrpValBrk
    {
        public string Company { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal OrderValue { get; set; }
        public string PriceGroupCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPriceGroupCode { get; set; }
        public decimal GlbOrderValue { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPriceGrpValBrk { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
