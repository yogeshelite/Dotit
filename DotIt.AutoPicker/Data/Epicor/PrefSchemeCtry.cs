using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrefSchemeCtry
    {
        public string Company { get; set; }
        public string PrefSchemeId { get; set; }
        public int CountryNum { get; set; }
        public bool GlobalPrefSchemeCtry { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
