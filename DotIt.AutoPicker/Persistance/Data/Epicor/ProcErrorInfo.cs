using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProcErrorInfo
    {
        public string Company { get; set; }
        public string ProcessType { get; set; }
        public DateTime? LogDate { get; set; }
        public int LogTime { get; set; }
        public string SlogTime { get; set; }
        public int TimeSeq { get; set; }
        public bool Error { get; set; }
        public string ProgramName { get; set; }
        public string MethodName { get; set; }
        public string ShortMessageText { get; set; }
        public string MessageText { get; set; }
        public string ProgramFile { get; set; }
        public int LineNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
