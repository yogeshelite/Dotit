using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPartXrefMfg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool InspectionReq { get; set; }
        public string LeadTime { get; set; }
        public string LifecycleStatus { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public string PartNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public int GlbMfgNum { get; set; }
        public string GlbMfgPartNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPartXrefMfg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
