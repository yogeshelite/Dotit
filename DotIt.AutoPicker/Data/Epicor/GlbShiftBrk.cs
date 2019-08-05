using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbShiftBrk
    {
        public decimal BreakEnd { get; set; }
        public int BreakNum { get; set; }
        public decimal BreakStart { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string DspBreakEnd { get; set; }
        public string DspBreakStart { get; set; }
        public int Shift { get; set; }
        public string GlbCompany { get; set; }
        public int GlbShift { get; set; }
        public int GlbBreakNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalShiftBrk { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
