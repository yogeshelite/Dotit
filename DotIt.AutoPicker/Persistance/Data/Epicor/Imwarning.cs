using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imwarning
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
