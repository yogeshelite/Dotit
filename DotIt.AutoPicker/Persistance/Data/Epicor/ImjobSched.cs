using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImjobSched
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
