using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Survey
    {
        public string Company { get; set; }
        public string ObjectName { get; set; }
        public string DataTableId { get; set; }
        public string ProcessMethod { get; set; }
        public bool Active { get; set; }
        public string InspPlanNum { get; set; }
        public string SpecId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
