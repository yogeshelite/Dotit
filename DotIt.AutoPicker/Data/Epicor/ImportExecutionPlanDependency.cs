using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportExecutionPlanDependency
    {
        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public long ExecutionPlanId { get; set; }
        public long DependsOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ImportExecutionPlan ImportExecutionPlan { get; set; }
    }
}
