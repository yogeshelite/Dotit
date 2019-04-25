using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcHistBrunRadtl
    {
        public string Company { get; set; }
        public decimal HistBrunRadtlId { get; set; }
        public decimal BrunId { get; set; }
        public decimal RabschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschDtlRatesId { get; set; }
        public DateTime? BtoDt { get; set; }
        public decimal Rate { get; set; }
        public DateTime? EffDt { get; set; }
        public decimal OldRate { get; set; }
        public DateTime? OldEffDt { get; set; }
        public bool IsNew { get; set; }
        public bool IsBondLoanRebill { get; set; }
        public bool InactivePending { get; set; }
        public string OtherAmt { get; set; }
        public string OtherBcd { get; set; }
        public bool IsBillEndDtnew { get; set; }
        public DateTime? OrigBillEndDt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool Inactive { get; set; }
        public bool IsTotalPerNew { get; set; }
        public int OrigTotalPer { get; set; }
        public decimal RabschDtlLeaveId { get; set; }
        public bool LeaveInactivePending { get; set; }
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
    }
}
