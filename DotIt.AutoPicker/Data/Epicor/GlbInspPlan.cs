using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbInspPlan
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string InspPlanNum { get; set; }
        public string PlanType { get; set; }
        public string GlbCompany { get; set; }
        public string GlbInspPlanNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalInspPlan { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
