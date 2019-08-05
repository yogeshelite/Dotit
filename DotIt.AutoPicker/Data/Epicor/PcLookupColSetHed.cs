using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcLookupColSetHed
    {
        public string Company { get; set; }
        public string LookupTblId { get; set; }
        public string ColSetId { get; set; }
        public string Description { get; set; }
        public bool Template { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
