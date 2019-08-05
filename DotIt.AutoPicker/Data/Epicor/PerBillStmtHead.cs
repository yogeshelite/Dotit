using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PerBillStmtHead
    {
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public DateTime? BillingDate { get; set; }
        public DateTime? SummarizationDate { get; set; }
        public int CustNum { get; set; }
        public string BillingNumber { get; set; }
        public bool ReadyToBill { get; set; }
        public int SummarizationDay { get; set; }
        public DateTime? DueDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? StartSumDate { get; set; }
        public DateTime? EndSumDate { get; set; }
        public decimal AmountToPay { get; set; }
        public bool CalcTaxGlb { get; set; }
        public int AdjInvoiceNum { get; set; }
    }
}
