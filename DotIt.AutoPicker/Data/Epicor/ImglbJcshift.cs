using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbJcshift
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string DiffMethod { get; set; }
        public string DiffQualifier { get; set; }
        public decimal DiffRate { get; set; }
        public string DspEndTime { get; set; }
        public string DspLunchEnd { get; set; }
        public string DspLunchStart { get; set; }
        public string DspStartTime { get; set; }
        public decimal EndTime { get; set; }
        public decimal LunchEnd { get; set; }
        public decimal LunchStart { get; set; }
        public int Shift { get; set; }
        public decimal StartTime { get; set; }
        public string GlbCompany { get; set; }
        public int GlbShift { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalJcshift { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
