using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImapinvMsc
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
        public int MscNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int SeqNum { get; set; }
        public string TaxCatId { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbInvoiceNum { get; set; }
        public int GlbInvoiceLine { get; set; }
        public int GlbMscNum { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public int InvExpSeq { get; set; }
        public bool Lcflag { get; set; }
        public int ContainerId { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public string IncomeTaxCode { get; set; }
        public int LcvendorNum { get; set; }
        public string LcdisburseMethod { get; set; }
        public decimal InMiscAmt { get; set; }
        public decimal DocInMiscAmt { get; set; }
        public decimal Rpt1InMiscAmt { get; set; }
        public decimal Rpt2InMiscAmt { get; set; }
        public decimal Rpt3InMiscAmt { get; set; }
        public int DevInt1 { get; set; }
        public int DevInt2 { get; set; }
        public decimal DevDec1 { get; set; }
        public decimal DevDec2 { get; set; }
        public decimal DevDec3 { get; set; }
        public decimal DevDec4 { get; set; }
        public bool DevLog1 { get; set; }
        public bool DevLog2 { get; set; }
        public string DevChar1 { get; set; }
        public string DevChar2 { get; set; }
        public DateTime? DevDate1 { get; set; }
        public DateTime? DevDate2 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool CorrectionDtl { get; set; }
        public bool NoTaxRecalc { get; set; }
        public string Code1099Id { get; set; }
        public string FormTypeId { get; set; }
        public string Gen1099Code { get; set; }
    }
}
