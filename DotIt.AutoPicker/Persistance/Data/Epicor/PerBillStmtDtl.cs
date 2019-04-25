using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PerBillStmtDtl
    {
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
