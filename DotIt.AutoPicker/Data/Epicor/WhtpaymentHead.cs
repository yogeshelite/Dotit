using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhtpaymentHead
    {
        public WhtpaymentHead()
        {
            WhtpaymentDtl = new HashSet<WhtpaymentDtl>();
        }

        public string Company { get; set; }
        public string ReportId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Module { get; set; }
        public string TaxEntityType { get; set; }
        public decimal WhtpaymentAmount { get; set; }
        public string BankAcctId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string BankTranRefNum { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string AdditionalTranRef { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public int ReportStatus { get; set; }
        public string Notes { get; set; }
        public decimal LatePaymentCharge { get; set; }
        public string NatureOfRemittance { get; set; }
        public string CustomerList { get; set; }
        public string SupplierList { get; set; }
        public string TaxCode { get; set; }
        public string TaxLiabilityList { get; set; }
        public string SubmitReportId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal PenaltyAmount { get; set; }

        public virtual ICollection<WhtpaymentDtl> WhtpaymentDtl { get; set; }
    }
}
