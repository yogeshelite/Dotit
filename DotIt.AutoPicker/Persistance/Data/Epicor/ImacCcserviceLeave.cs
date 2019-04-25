using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacCcserviceLeave
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ServicePlanId { get; set; }
        public int ServiceLeaveId { get; set; }
        public bool Leave { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public string LeaveReason { get; set; }
        public bool SuspendService { get; set; }
        public DateTime? SuspendServiceStartDate { get; set; }
        public DateTime? SuspendServiceEndDate { get; set; }
        public string SuspendServiceReason { get; set; }
        public bool SuspendBilling { get; set; }
        public DateTime? SuspendBillingStartDate { get; set; }
        public DateTime? SuspendBillingEndDate { get; set; }
        public string SuspendBillingReason { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Ocready { get; set; }
    }
}
