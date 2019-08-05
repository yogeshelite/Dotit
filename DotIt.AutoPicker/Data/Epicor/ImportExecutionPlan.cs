using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportExecutionPlan
    {
        public ImportExecutionPlan()
        {
            ImportExecutionPlanDependency = new HashSet<ImportExecutionPlanDependency>();
            ImportTask = new HashSet<ImportTask>();
        }

        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public long ExecutionPlanId { get; set; }
        public long ExecutionBlockId { get; set; }
        public string ExecutionAction { get; set; }
        public int TaskSeq { get; set; }
        public string Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ImportExecutionPlanDependency> ImportExecutionPlanDependency { get; set; }
        public virtual ICollection<ImportTask> ImportTask { get; set; }
    }
}
