using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPrefScheme
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string PrefSchemeId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPrefSchemeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPrefScheme { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
