using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrebateHdr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RebateId { get; set; }
        public string RebateDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int GraceDays { get; set; }
        public bool Active { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal AccruedAmount { get; set; }
        public int CustNum { get; set; }
        public string AccrualType { get; set; }
        public bool BillToFlag { get; set; }
        public string RebateForm { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
