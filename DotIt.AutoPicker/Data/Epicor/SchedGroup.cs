using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SchedGroup
    {
        public string Company { get; set; }
        public string ApsschedulerName { get; set; }
        public string ModuleId { get; set; }
        public string Type { get; set; }
        public string WorkStationId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
