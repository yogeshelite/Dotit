using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LookupTable
    {
        public int MapUid { get; set; }
        public string DisplayName { get; set; }
        public string LookupName { get; set; }
        public string DetailedDescription { get; set; }
        public string Company { get; set; }
        public bool GlobalLookupTable { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
