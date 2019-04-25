using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsysAgent
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string AgentId { get; set; }
        public string AgentDesc { get; set; }
        public string AgentType { get; set; }
        public string AgentStatus { get; set; }
        public bool Started { get; set; }
        public DateTime? StartedOn { get; set; }
        public string StartUser { get; set; }
        public bool AutoStart { get; set; }
        public int ProcessingDelay { get; set; }
        public string SysUserId { get; set; }
        public string SysPassWord { get; set; }
        public string FileRootDir { get; set; }
        public int MaxSimultaneousTasks { get; set; }
        public string SecCode { get; set; }
        public int TaskPurgeIntervalDays { get; set; }
        public int ReportPurgeIntervalTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SysAppserverUrl { get; set; }
        public string SysDnsendpointIdentity { get; set; }
    }
}
