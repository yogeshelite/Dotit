using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MrpProc
    {
        public string Company { get; set; }
        public string ProcessName { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessStop { get; set; }
        public string ProcessType { get; set; }
        public int NumStart { get; set; }
        public int RangeStart { get; set; }
        public bool Controller { get; set; }
        public int RangeEnd { get; set; }
        public bool SystemProc { get; set; }
        public int MaxStart { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
