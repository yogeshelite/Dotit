using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPartXrefMfg
    {
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
