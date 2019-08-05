using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PadayDtl
    {
        public string Company { get; set; }
        public string PadayId { get; set; }
        public int Paperiod { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
