using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imarpndtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal DocDiscountAmount { get; set; }
        public decimal DocTranAmt { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool GetDfltTaxIds { get; set; }
        public bool Glposted { get; set; }
        public int InvoiceNum { get; set; }
        public string LegalNumber { get; set; }
        public bool Posted { get; set; }
        public string RateGrpCode { get; set; }
        public decimal RoundDiff { get; set; }
        public decimal Rpt1DiscountAmt { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2DiscountAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3DiscountAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public string TaxRegionCode { get; set; }
        public decimal TranAmt { get; set; }
        public DateTime? TranDate { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public int InvoiceRef { get; set; }
        public decimal Dnamount { get; set; }
        public decimal DocDnAmount { get; set; }
        public decimal Rpt1DnAmount { get; set; }
        public decimal Rpt2DnAmount { get; set; }
        public decimal Rpt3DnAmount { get; set; }
        public string TranType { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal DocSelfAssessAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public decimal DocWithholdAmt { get; set; }
        public int FiscalPeriod { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string Reference { get; set; }
        public decimal Rpt1SelfAssessAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt1WithholdAmt { get; set; }
        public decimal Rpt2SelfAssessAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt2WithholdAmt { get; set; }
        public decimal Rpt3SelfAssessAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public decimal Rpt3WithholdAmt { get; set; }
        public decimal SelfAssessAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal WithholdAmt { get; set; }
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
