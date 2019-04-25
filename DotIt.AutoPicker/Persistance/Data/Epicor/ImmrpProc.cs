using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImmrpProc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
