using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPurMiscVend
    {
        public string Company { get; set; }
        public decimal Lcamount { get; set; }
        public string LccurrencyCode { get; set; }
        public string LcdisburseMethod { get; set; }
        public string MiscCode { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public int VendorNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMiscCode { get; set; }
        public int GlbVendorNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPurMiscVend { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
