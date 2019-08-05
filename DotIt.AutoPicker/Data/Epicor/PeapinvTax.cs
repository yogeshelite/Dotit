using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PeapinvTax
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public int EcacquisitionSeq { get; set; }
        public int LineNum { get; set; }
        public string ResolutionNum { get; set; }
        public string TextCode { get; set; }
        public bool ManAdd { get; set; }
        public bool Manual { get; set; }
        public decimal Percent { get; set; }
        public decimal ReportableAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal DefTaxableAmt { get; set; }
        public decimal DefTaxAmt { get; set; }
        public decimal DedTaxAmt { get; set; }
        public decimal FixedAmount { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public decimal DocTaxAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
