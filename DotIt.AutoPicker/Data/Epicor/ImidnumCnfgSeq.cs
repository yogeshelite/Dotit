using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImidnumCnfgSeq
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FormatId { get; set; }
        public string DefaultPrefix { get; set; }
        public int TransYear { get; set; }
        public int StartSequence { get; set; }
        public int EndSequence { get; set; }
        public bool Active { get; set; }
        public int NumberSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
