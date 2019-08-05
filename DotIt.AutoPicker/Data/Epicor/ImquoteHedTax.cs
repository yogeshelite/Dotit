using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquoteHedTax
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
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal ReportableAmt { get; set; }
        public decimal Percent { get; set; }
        public decimal DocTaxAmt { get; set; }
        public decimal DocTaxableAmt { get; set; }
        public decimal DocReportableAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt1TaxableAmt { get; set; }
        public decimal Rpt1ReportableAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt2TaxableAmt { get; set; }
        public decimal Rpt2ReportableAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public decimal Rpt3TaxableAmt { get; set; }
        public decimal Rpt3ReportableAmt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ClaimsTax { get; set; }
    }
}
