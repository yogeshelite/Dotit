using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbBsbdnCd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public bool ApplyConLbr { get; set; }
        public bool ApplyFees { get; set; }
        public bool ApplyLbr { get; set; }
        public bool ApplyMtl { get; set; }
        public bool ApplyOdc { get; set; }
        public bool ApplySubcon { get; set; }
        public string BdnCd { get; set; }
        public string BdnOnBdnList { get; set; }
        public string BdnSetId { get; set; }
        public string Company { get; set; }
        public int ProcSeq { get; set; }
        public string GlbCompany { get; set; }
        public string GlbBdnSetId { get; set; }
        public string GlbBdnCd { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalBsbdnCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
