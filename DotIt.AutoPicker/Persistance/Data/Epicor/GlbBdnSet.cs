using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbBdnSet
    {
        public string BdnSetId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public string GlbCompany { get; set; }
        public string GlbBdnSetId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalBdnSet { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
