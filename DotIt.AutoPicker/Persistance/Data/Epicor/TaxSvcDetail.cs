using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxSvcDetail
    {
        public string Company { get; set; }
        public string TaxSvcId { get; set; }
        public int OrderNum { get; set; }
        public int InvoiceNum { get; set; }
        public int LineNum { get; set; }
        public int OrderRelNum { get; set; }
        public string PartNum { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtPrice { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Discount { get; set; }
        public string TaxCategory { get; set; }
        public string FromAddress1 { get; set; }
        public string FromAddress2 { get; set; }
        public string FromAddress3 { get; set; }
        public string FromCity { get; set; }
        public string FromState { get; set; }
        public string FromZip { get; set; }
        public string FromCountry { get; set; }
        public string ToAddress1 { get; set; }
        public string ToAddress2 { get; set; }
        public string ToAddress3 { get; set; }
        public string ToCity { get; set; }
        public string ToState { get; set; }
        public string ToZip { get; set; }
        public string ToCountry { get; set; }
        public int QuoteNum { get; set; }
        public string TaxRegionCode { get; set; }
        public int DocId { get; set; }
        public string Tcno { get; set; }
        public decimal Tcrate { get; set; }
        public decimal Tchrate { get; set; }
        public decimal Tctax { get; set; }
        public decimal Tchtax { get; set; }
        public bool Tctaxability { get; set; }
        public bool Tchtaxability { get; set; }
        public decimal Tctaxable { get; set; }
        public decimal Tchtaxable { get; set; }
        public string TctaxCode { get; set; }
        public string TchtaxCode { get; set; }
        public int ItemSeq { get; set; }
        public string ApinvoiceNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
