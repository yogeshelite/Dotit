using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PriceGroup
    {
        public string Company { get; set; }
        public string PriceGroupCode { get; set; }
        public string Description { get; set; }
        public bool QuantityDiscount { get; set; }
        public bool ValueDiscount { get; set; }
        public bool GlobalPriceGroup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
