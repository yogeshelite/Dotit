using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportTask
    {
        public ImportTask()
        {
            ImportTaskLog = new HashSet<ImportTaskLog>();
        }

        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public long ExecutionPlanId { get; set; }
        public long TaskId { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public string Status { get; set; }
        public int NumOfInputRows { get; set; }
        public string UserId { get; set; }
        public string ProcessId { get; set; }
        public int ThreadId { get; set; }
        public string ServerName { get; set; }
        public string PrimaryKey { get; set; }
        public int? Duration { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ImportDocument ImportDocument { get; set; }
        public virtual ImportExecutionPlan ImportExecutionPlan { get; set; }
        public virtual ICollection<ImportTaskLog> ImportTaskLog { get; set; }
    }
}
