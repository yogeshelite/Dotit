using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlacctSegValues
    {
        public string Company { get; set; }
        public string SegmentParent { get; set; }
        public int SegSequence { get; set; }
        public string SegValue { get; set; }
        public string SegAbbrev { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
