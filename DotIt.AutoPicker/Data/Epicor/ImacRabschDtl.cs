using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacRabschDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschHeadId { get; set; }
        public string Bcd { get; set; }
        public string ParentBcd { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal BschDtlId { get; set; }
        public DateTime? BillStartDt { get; set; }
        public DateTime? BillEndDt { get; set; }
        public int NbrOfChrgPer { get; set; }
        public int TotalPer { get; set; }
        public int TotalPerCntr { get; set; }
        public string BillingDesc { get; set; }
        public bool Overridden { get; set; }
        public DateTime? BtoDt { get; set; }
        public bool BillingComplete { get; set; }
        public bool IsBillEndDtnew { get; set; }
        public DateTime? OrigBillEndDt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public decimal Raid { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool IsTotalPerNew { get; set; }
        public int OrigTotalPer { get; set; }
        public string ExpenditureType { get; set; }
        public string IncomeBcd { get; set; }
    }
}
