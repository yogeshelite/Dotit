using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRabschDtlLeave
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RabschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschDtlLeaveId { get; set; }
        public int ServicePlanId { get; set; }
        public int ServiceLeaveId { get; set; }
        public bool Leave { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public bool SuspendService { get; set; }
        public DateTime? SuspendServiceStartDate { get; set; }
        public DateTime? SuspendServiceEndDate { get; set; }
        public bool SuspendBilling { get; set; }
        public DateTime? SuspendBillingStartDate { get; set; }
        public DateTime? SuspendBillingEndDate { get; set; }
        public bool IsLeaveNew { get; set; }
        public bool OrigLeave { get; set; }
        public DateTime? OrigLeaveStartDate { get; set; }
        public DateTime? OrigLeaveEndDate { get; set; }
        public bool IsSuspendServiceNew { get; set; }
        public bool OrigSuspendService { get; set; }
        public DateTime? OrigSuspendServiceStartDate { get; set; }
        public DateTime? OrigSuspendServiceEndDate { get; set; }
        public bool IsSuspendBillingNew { get; set; }
        public bool OrigSuspendBilling { get; set; }
        public DateTime? OrigSuspendBillingStartDate { get; set; }
        public DateTime? OrigSuspendBillingEndDate { get; set; }
        public bool Inactive { get; set; }
        public bool LeaveInactivePending { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
