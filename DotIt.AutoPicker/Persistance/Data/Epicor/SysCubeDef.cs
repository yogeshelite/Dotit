using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysCubeDef
    {
        public SysCubeDef()
        {
            SysCubeParam = new HashSet<SysCubeParam>();
        }

        public string Company { get; set; }
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

        public virtual ICollection<SysCubeParam> SysCubeParam { get; set; }
    }
}
