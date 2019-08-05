using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MrpProcQueue
    {
        public string Company { get; set; }
        public string ProcessType { get; set; }
        public string GroupId { get; set; }
        public string ProcessName { get; set; }
        public string Queue { get; set; }
        public string QueueText { get; set; }
        public int Order { get; set; }
        public string Qtype { get; set; }
        public bool SystemProc { get; set; }
        public string GroupStartMsg { get; set; }
        public string GroupEndMsg { get; set; }
        public bool PartLevel { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
