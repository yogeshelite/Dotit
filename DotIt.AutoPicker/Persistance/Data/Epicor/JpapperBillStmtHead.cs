using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpapperBillStmtHead
    {
        public JpapperBillStmtHead()
        {
            JpapperBillStmtDtl = new HashSet<JpapperBillStmtDtl>();
            JpapperBillStmtPay = new HashSet<JpapperBillStmtPay>();
        }

        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public int VendorNum { get; set; }
        public DateTime? BillingDate { get; set; }
        public DateTime? SummarizationDate { get; set; }
        public string BillingNumber { get; set; }
        public bool ReadyToBill { get; set; }
        public int SummarizationDay { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartSumDate { get; set; }
        public DateTime? EndSumDate { get; set; }
        public decimal AmountToPay { get; set; }
        public bool CalcTaxGlb { get; set; }
        public string AdjInvoiceNum { get; set; }
        public string TranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual JpapperBillStmtGrp JpapperBillStmtGrp { get; set; }
        public virtual ICollection<JpapperBillStmtDtl> JpapperBillStmtDtl { get; set; }
        public virtual ICollection<JpapperBillStmtPay> JpapperBillStmtPay { get; set; }
    }
}
