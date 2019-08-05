using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShiftBrk
    {
        public string Company { get; set; }
        public int Shift { get; set; }
        public int BreakNum { get; set; }
        public string Description { get; set; }
        public decimal BreakStart { get; set; }
        public decimal BreakEnd { get; set; }
        public string DspBreakStart { get; set; }
        public string DspBreakEnd { get; set; }
        public bool GlobalShiftBrk { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
