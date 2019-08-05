using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacBcycle
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BcycleCd { get; set; }
        public string BcycleDesc { get; set; }
        public string Period { get; set; }
        public int BillFreq { get; set; }
        public string BillFrom { get; set; }
        public DateTime? PeriodStartDt { get; set; }
        public string BillingIn { get; set; }
        public string WeeklyBillStart { get; set; }
        public string WeeklyBillEnd { get; set; }
        public string MonthlyBillStart { get; set; }
        public string MonthlyBillEnd { get; set; }
        public int EndAftrOccur { get; set; }
        public bool IsFirstProrate { get; set; }
        public bool IsFinalProrate { get; set; }
        public string Calculation { get; set; }
        public string InvDt { get; set; }
        public string InvDtor { get; set; }
        public int InvDays { get; set; }
        public int InvDayOfMnth { get; set; }
        public string InvBefore { get; set; }
        public string InvDayPeriod { get; set; }
        public string InvMonth { get; set; }
        public bool IsAlwOverride { get; set; }
        public bool DeferRev { get; set; }
        public bool FullPeriod { get; set; }
        public string FullPeriodDay { get; set; }
        public string FullPeriodMonth { get; set; }
        public int FullPeriodDt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
