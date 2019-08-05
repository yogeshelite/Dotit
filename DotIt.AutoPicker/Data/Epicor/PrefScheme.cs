using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrefScheme
    {
        public string Company { get; set; }
        public string PrefSchemeId { get; set; }
        public string Description { get; set; }
        public bool GlobalPrefScheme { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
