using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Wfstage
    {
        public string Company { get; set; }
        public string WorkflowType { get; set; }
        public string WfstageId { get; set; }
        public string Description { get; set; }
        public string CustomerType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
