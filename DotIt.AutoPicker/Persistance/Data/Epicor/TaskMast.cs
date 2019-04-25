using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaskMast
    {
        public string Company { get; set; }
        public string TaskId { get; set; }
        public string TaskDescription { get; set; }
        public string RoleCode { get; set; }
        public bool Mandatory { get; set; }
        public bool SendAlertComplete { get; set; }
        public bool SendAlertCreate { get; set; }
        public int PriorityCode { get; set; }
        public string TaskComment { get; set; }
        public bool Inactive { get; set; }
        public string TypeCode { get; set; }
        public bool PasswordReq { get; set; }
        public bool AnyApprover { get; set; }
        public int ApprovalSupervisorLevel { get; set; }
        public bool SubmitTask { get; set; }
        public bool GlobalTaskMast { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
