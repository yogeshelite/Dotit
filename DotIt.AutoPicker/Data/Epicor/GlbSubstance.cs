using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbSubstance
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string SubstanceId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSubstanceId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSubstance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
