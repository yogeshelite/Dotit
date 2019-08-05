using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PeinvcTax
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
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
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public string ResolutionNum { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public decimal DefTaxableAmt { get; set; }
        public decimal DocDefTaxableAmt { get; set; }
        public decimal DefTaxAmt { get; set; }
        public decimal DocDefTaxAmt { get; set; }
        public bool ManAdd { get; set; }
        public decimal DedTaxAmt { get; set; }
        public decimal FixedAmount { get; set; }
        public string TextCode { get; set; }
        public decimal TaxAmtVar { get; set; }
        public decimal DocTaxAmtVar { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
