using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WfgrpMbr
    {
        public string Company { get; set; }
        public string WorkflowType { get; set; }
        public string WfgroupId { get; set; }
        public string SalesRepCode { get; set; }
        public string RoleCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
