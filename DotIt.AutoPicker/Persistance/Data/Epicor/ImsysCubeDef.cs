using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsysCubeDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public Guid CubeGuid { get; set; }
        public string CubeId { get; set; }
        public string QueryId { get; set; }
        public DateTime? RunDate { get; set; }
        public string Description { get; set; }
        public bool IsSummaryByBaq { get; set; }
        public bool IsSummaryByDate { get; set; }
        public string DeleteAction { get; set; }
        public string Schedule { get; set; }
        public bool IsDynamic { get; set; }
        public bool IsRecurring { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string RunDateToken { get; set; }
        public string ProcessId { get; set; }
        public long SysTaskNum { get; set; }
        public int AgentTaskNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
    }
}
