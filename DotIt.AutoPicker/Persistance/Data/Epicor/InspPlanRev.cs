using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InspPlanRev
    {
        public string Company { get; set; }
        public string InspPlanNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string RevDescription { get; set; }
        public string SpecId { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool GlobalInspPlanRev { get; set; }
        public bool GlobalLock { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
