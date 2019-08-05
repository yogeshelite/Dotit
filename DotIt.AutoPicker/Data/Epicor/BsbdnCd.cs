using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BsbdnCd
    {
        public string Company { get; set; }
        public string BdnSetId { get; set; }
        public string BdnCd { get; set; }
        public int ProcSeq { get; set; }
        public bool ApplyLbr { get; set; }
        public bool ApplyMtl { get; set; }
        public bool ApplySubcon { get; set; }
        public bool ApplyConLbr { get; set; }
        public bool ApplyOdc { get; set; }
        public bool ApplyFees { get; set; }
        public string BdnOnBdnList { get; set; }
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public bool GlobalBsbdnCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
