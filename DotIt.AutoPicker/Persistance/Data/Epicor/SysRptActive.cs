using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysRptActive
    {
        public long SysTaskNum { get; set; }
        public Guid ReportInstanceId { get; set; }
        public string Company { get; set; }
        public string UserId { get; set; }
        public DateTime StartedOn { get; set; }
        public string TaskStage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
