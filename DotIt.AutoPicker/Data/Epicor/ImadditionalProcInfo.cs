using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImadditionalProcInfo
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public long ErrSequence { get; set; }
        public string ProcessType { get; set; }
        public DateTime? LogDatetime { get; set; }
        public string SlogTime { get; set; }
        public bool Error { get; set; }
        public string ProgramName { get; set; }
        public string MethodName { get; set; }
        public string MessageText { get; set; }
        public string ProgramFile { get; set; }
        public long LineNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
