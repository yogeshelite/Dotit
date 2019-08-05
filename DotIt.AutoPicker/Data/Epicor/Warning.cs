using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Warning
    {
        public string Company { get; set; }
        public int LabWarnNum { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool RptShpTracker { get; set; }
        public bool RptDataCollect { get; set; }
        public bool RptLbrEnt { get; set; }
        public bool RptLbrEdit { get; set; }
        public int VariancePct { get; set; }
        public string WarnType { get; set; }
        public bool AlertFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
