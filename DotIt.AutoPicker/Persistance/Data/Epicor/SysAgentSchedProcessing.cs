using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysAgentSchedProcessing
    {
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public DateTime? ProcessingStartedOn { get; set; }
        public Guid SysAgentSchedSysRowId { get; set; }
    }
}
