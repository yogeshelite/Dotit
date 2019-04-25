using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AuditRev
    {
        public string Company { get; set; }
        public string AuditId { get; set; }
        public string RevisionNum { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string InspPlanNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
