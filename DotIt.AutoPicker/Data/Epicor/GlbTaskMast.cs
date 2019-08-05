using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTaskMast
    {
        public bool AnyApprover { get; set; }
        public int ApprovalSupervisorLevel { get; set; }
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public bool Mandatory { get; set; }
        public bool PasswordReq { get; set; }
        public int PriorityCode { get; set; }
        public string RoleCode { get; set; }
        public bool SendAlertComplete { get; set; }
        public bool SendAlertCreate { get; set; }
        public bool SubmitTask { get; set; }
        public string TaskComment { get; set; }
        public string TaskDescription { get; set; }
        public string TaskId { get; set; }
        public string TypeCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaskId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaskMast { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
