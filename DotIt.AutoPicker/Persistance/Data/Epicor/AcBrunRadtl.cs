using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcBrunRadtl
    {
        public string Company { get; set; }
        public decimal BrunRadtlId { get; set; }
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
        public int TotalPerCntr { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string BrunChar01 { get; set; }
        public string BrunChar02 { get; set; }
        public string BrunChar03 { get; set; }
        public DateTime? BrunDate01 { get; set; }
        public DateTime? BrunDate02 { get; set; }
        public DateTime? BrunDate03 { get; set; }
        public DateTime? BrunDate04 { get; set; }
        public DateTime? BrunDate05 { get; set; }
        public DateTime? BrunDate06 { get; set; }
        public decimal BrunId01 { get; set; }
        public decimal BrunId02 { get; set; }
        public decimal BrunId03 { get; set; }
        public decimal BrunId04 { get; set; }
        public decimal BrunId05 { get; set; }
        public decimal BrunId06 { get; set; }
        public decimal BrunDec01 { get; set; }
        public decimal BrunDec02 { get; set; }
        public decimal BrunDec03 { get; set; }
        public decimal BrunDec04 { get; set; }
        public decimal BrunDec05 { get; set; }
        public decimal BrunDec06 { get; set; }
        public bool BrunBit01 { get; set; }
        public bool BrunBit02 { get; set; }
        public bool BrunBit03 { get; set; }
        public bool BrunBit04 { get; set; }
        public bool BrunBit05 { get; set; }
        public bool BrunBit06 { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
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
