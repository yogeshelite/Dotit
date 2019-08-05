using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Appndtl
    {
        public string Company { get; set; }
        public int AppndtlLine { get; set; }
        public string BankAcctId { get; set; }
        public decimal DiscAmt { get; set; }
        public decimal DocDiscAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public decimal DocTranAmt { get; set; }
        public string EntryPerson { get; set; }
        public bool Glposted { get; set; }
        public string InvoiceNum { get; set; }
        public decimal RoundDiff { get; set; }
        public decimal Rpt1DiscAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2DiscAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3DiscAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public string TaxRegionCode { get; set; }
        public decimal TranAmt { get; set; }
        public DateTime? TranDate { get; set; }
        public int VendorNum { get; set; }
        public int HeadNum { get; set; }
        public bool Voided { get; set; }
        public string GroupId { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalPeriod { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string LegalNumber { get; set; }
        public bool Posted { get; set; }
        public string Description { get; set; }
        public string TranType { get; set; }
        public decimal DocSelfAssessAmt { get; set; }
        public decimal DocWithholdAmt { get; set; }
        public decimal SelfAssessAmt { get; set; }
        public decimal WithholdAmt { get; set; }
        public decimal Rpt1SelfAssessAmt { get; set; }
        public decimal Rpt1WithholdAmt { get; set; }
        public decimal Rpt2SelfAssessAmt { get; set; }
        public decimal Rpt2WithholdAmt { get; set; }
        public decimal Rpt3SelfAssessAmt { get; set; }
        public decimal Rpt3WithholdAmt { get; set; }
        public int FirstHeadNum { get; set; }
        public string GainLossType { get; set; }
        public bool ReverseGl { get; set; }
        public DateTime? RevalueDate { get; set; }
        public decimal RevalueBal { get; set; }
        public decimal DocRevalueBal { get; set; }
        public decimal Rpt1RevalueBal { get; set; }
        public decimal Rpt2RevalueBal { get; set; }
        public decimal Rpt3RevalueBal { get; set; }
        public string TranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
