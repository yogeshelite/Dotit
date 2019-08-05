using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbRestrictionSubstance
    {
        public string Company { get; set; }
        public string RestrictionTypeId { get; set; }
        public string SubstanceId { get; set; }
        public decimal Threshold { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRestrictionTypeId { get; set; }
        public string GlbSubstanceId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRestrictionSubstance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
