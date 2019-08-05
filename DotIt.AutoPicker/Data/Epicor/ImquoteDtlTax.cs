using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquoteDtlTax
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public int EcacquisitionSeq { get; set; }
        public decimal ReportableAmt { get; set; }
        public decimal DocReportableAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal DocTaxableAmt { get; set; }
        public decimal Percent { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public bool Manual { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public bool ReverseCharge { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal Rpt1ReportableAmt { get; set; }
        public decimal Rpt2ReportableAmt { get; set; }
        public decimal Rpt3ReportableAmt { get; set; }
        public decimal Rpt1TaxableAmt { get; set; }
        public decimal Rpt2TaxableAmt { get; set; }
        public decimal Rpt3TaxableAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public string ResolutionNum { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public decimal DefTaxableAmt { get; set; }
        public decimal DocDefTaxableAmt { get; set; }
        public decimal Rpt1DefTaxableAmt { get; set; }
        public decimal Rpt2DefTaxableAmt { get; set; }
        public decimal Rpt3DefTaxableAmt { get; set; }
        public decimal DefTaxAmt { get; set; }
        public decimal DocDefTaxAmt { get; set; }
        public decimal Rpt1DefTaxAmt { get; set; }
        public decimal Rpt2DefTaxAmt { get; set; }
        public decimal Rpt3DefTaxAmt { get; set; }
        public bool ManAdd { get; set; }
        public decimal DedTaxAmt { get; set; }
        public decimal DocDedTaxAmt { get; set; }
        public decimal Rpt1DedTaxAmt { get; set; }
        public decimal Rpt2DedTaxAmt { get; set; }
        public decimal Rpt3DedTaxAmt { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal DocFixedAmount { get; set; }
        public decimal Rpt1FixedAmount { get; set; }
        public decimal Rpt2FixedAmount { get; set; }
        public decimal Rpt3FixedAmount { get; set; }
        public string TextCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
