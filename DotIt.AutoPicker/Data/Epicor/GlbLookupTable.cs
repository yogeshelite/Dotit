using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbLookupTable
    {
        public string Company { get; set; }
        public string DetailedDescription { get; set; }
        public string DisplayName { get; set; }
        public string LookupName { get; set; }
        public int MapUid { get; set; }
        public string GlbCompany { get; set; }
        public int GlbMapUid { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalLookupTable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
