using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SpecRev
    {
        public string Company { get; set; }
        public string SpecType { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string RevDescription { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string InspPlanPartNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool GlobalSpecRev { get; set; }
        public bool GlobalLock { get; set; }
        public int GroupSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
