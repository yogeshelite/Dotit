using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RebateHdr
    {
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
