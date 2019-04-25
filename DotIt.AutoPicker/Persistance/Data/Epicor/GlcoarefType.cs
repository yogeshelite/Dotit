using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlcoarefType
    {
        public string Company { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public string RefType { get; set; }
        public string RefTypeDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
