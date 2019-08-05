using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcRange
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public int SegmentNbr { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
