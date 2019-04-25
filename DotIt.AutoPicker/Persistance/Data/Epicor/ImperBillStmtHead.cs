using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImperBillStmtHead
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
