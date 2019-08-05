using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbInspPlanRev
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Company { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string InspPlanNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string RevDescription { get; set; }
        public string GlbCompany { get; set; }
        public string GlbInspPlanNum { get; set; }
        public string GlbInspPlanRevNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalInspPlanRev { get; set; }
        public bool GlobalLock { get; set; }
        public string SpecId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
