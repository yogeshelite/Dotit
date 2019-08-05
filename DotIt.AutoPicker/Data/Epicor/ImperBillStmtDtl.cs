using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImperBillStmtDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public DateTime? BillingDate { get; set; }
        public DateTime? SummarizationDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int CustNum { get; set; }
        public int InvoiceNum { get; set; }
        public string BillingNumber { get; set; }
        public bool ReadyToBill { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
