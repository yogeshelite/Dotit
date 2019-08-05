using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbShiftBrk
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
