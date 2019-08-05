using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PriceGrpValBrk
    {
        public string Company { get; set; }
        public string PriceGroupCode { get; set; }
        public decimal OrderValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool GlobalPriceGrpValBrk { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
