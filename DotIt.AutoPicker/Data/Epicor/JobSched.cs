using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobSched
    {
        public string Company { get; set; }
        public string DcduserId { get; set; }
        public int ScheduleId { get; set; }
        public string Description { get; set; }
        public DateTime? SavedDate { get; set; }
        public int SavedTime { get; set; }
        public DateTime? RestoredDate { get; set; }
        public int RestoredTime { get; set; }
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public string RestoreLog { get; set; }
        public string CommentText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
