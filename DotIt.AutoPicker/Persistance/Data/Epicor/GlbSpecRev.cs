using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSpecRev
    {
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Company { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string InspPlanPartNum { get; set; }
        public string RevDescription { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSpecId { get; set; }
        public string GlbSpecRevNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSpecRev { get; set; }
        public string SpecType { get; set; }
        public string GlbSpecType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
