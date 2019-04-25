using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Wfgroup
    {
        public string Company { get; set; }
        public string WorkflowType { get; set; }
        public string WfgroupId { get; set; }
        public string Description { get; set; }
        public string DefTaskSetId { get; set; }
        public bool Inactive { get; set; }
        public string PrimeSalesRepCode { get; set; }
        public string Comment { get; set; }
        public string ParentWfgroupId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
