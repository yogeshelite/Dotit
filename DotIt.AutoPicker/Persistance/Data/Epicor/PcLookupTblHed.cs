using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcLookupTblHed
    {
        public string Company { get; set; }
        public string LookupTblId { get; set; }
        public string Description { get; set; }
        public bool GlobalLookup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
