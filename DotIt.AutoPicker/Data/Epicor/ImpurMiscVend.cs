using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpurMiscVend
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
