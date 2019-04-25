using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysTask
    {
        public SysTask()
        {
            SysTaskLog = new HashSet<SysTaskLog>();
            SysTaskParam = new HashSet<SysTaskParam>();
        }

        public long SysTaskNum { get; set; }
        public string TaskDescription { get; set; }
        public string TaskType { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public string SubmitUser { get; set; }
        public string TaskStatus { get; set; }
        public string Company { get; set; }
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public int AgentTaskNum { get; set; }
        public string RunProcedure { get; set; }
        public string InitiatorSource { get; set; }
        public string ActivityMsg { get; set; }
        public bool History { get; set; }
        public string TaskNote { get; set; }
        public DateTime? LastActivityOn { get; set; }
        public string UserPidinfo { get; set; }
        public string ProcessId { get; set; }
        public bool IsSystemTask { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int ProgressPercent { get; set; }

        public virtual ICollection<SysTaskLog> SysTaskLog { get; set; }
        public virtual ICollection<SysTaskParam> SysTaskParam { get; set; }
    }
}
