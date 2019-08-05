using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PurMiscVend
    {
        public string Company { get; set; }
        public string MiscCode { get; set; }
        public int VendorNum { get; set; }
        public decimal Lcamount { get; set; }
        public string LcdisburseMethod { get; set; }
        public string LccurrencyCode { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public bool GlobalPurMiscVend { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
