using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcWfgroup
    {
        public string Company { get; set; }
        public string WorkflowType { get; set; }
        public string WfgroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string LockMode { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
