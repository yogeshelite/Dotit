using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysAgentTask
    {
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public int AgentTaskNum { get; set; }
        public string TaskDesc { get; set; }
        public string TaskType { get; set; }
        public string RunProcedure { get; set; }
        public string RunMethod { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public string SubmitUser { get; set; }
        public string ParamMaintProgram { get; set; }
        public string Company { get; set; }
        public string TaskNote { get; set; }
        public string ProcessSetSystemCode { get; set; }
        public string ProcessId { get; set; }
        public int ProcessTaskNum { get; set; }
        public bool IsSystemTask { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ProcessSetCompany { get; set; }
    }
}
