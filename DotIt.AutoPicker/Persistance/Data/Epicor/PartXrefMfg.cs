using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartXrefMfg
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public string LifecycleStatus { get; set; }
        public string LeadTime { get; set; }
        public bool InspectionReq { get; set; }
        public bool GlobalPartXrefMfg { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
