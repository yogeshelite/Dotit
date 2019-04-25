using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPrefSchemeCtry
    {
        public string Company { get; set; }
        public int CountryNum { get; set; }
        public string PrefSchemeId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPrefSchemeId { get; set; }
        public int GlbCountryNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPrefSchemeCtry { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
