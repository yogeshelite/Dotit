using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPriceGroup
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string PriceGroupCode { get; set; }
        public string ProdGroupList { get; set; }
        public bool QuantityDiscount { get; set; }
        public bool ValueDiscount { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPriceGroupCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPriceGroup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
