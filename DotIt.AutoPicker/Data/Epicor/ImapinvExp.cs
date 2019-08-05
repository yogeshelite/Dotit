using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImapinvExp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int InvExpSeq { get; set; }
        public decimal ExpAmt { get; set; }
        public string RefType { get; set; }
        public string RefCode { get; set; }
        public string RefCodeDesc { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbInvoiceNum { get; set; }
        public int GlbInvoiceLine { get; set; }
        public int GlbInvExpSeq { get; set; }
        public string ExtCompanyId { get; set; }
        public string ExtRefType { get; set; }
        public string ExtRefCode { get; set; }
        public bool MultiCompany { get; set; }
        public decimal Rpt1ExpAmt { get; set; }
        public decimal Rpt2ExpAmt { get; set; }
        public decimal Rpt3ExpAmt { get; set; }
        public decimal DocExpAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool NonDedTax { get; set; }
        public string NonDedTaxRelatedToSchema { get; set; }
        public string NonDedTaxRelatedToTable { get; set; }
        public Guid NonDedTaxRelatedToSysRowId { get; set; }
    }
}
