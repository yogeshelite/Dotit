using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Pomisc
    {
        public Pomisc()
        {
            PodetailMiscTax = new HashSet<PodetailMiscTax>();
        }

        public string Company { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public bool Taxable { get; set; }
        public decimal InvoicedAmt { get; set; }
        public decimal DocInvoicedAmt { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderSeqNum { get; set; }
        public bool Linked { get; set; }
        public string ExtCompany { get; set; }
        public decimal Rpt1InvoicedAmt { get; set; }
        public decimal Rpt2InvoicedAmt { get; set; }
        public decimal Rpt3InvoicedAmt { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal InMiscAmt { get; set; }
        public decimal DocInMiscAmt { get; set; }
        public decimal Rpt1InMiscAmt { get; set; }
        public decimal Rpt2InMiscAmt { get; set; }
        public decimal Rpt3InMiscAmt { get; set; }
        public decimal InInvoiceAmt { get; set; }
        public decimal DocInInvoiceAmt { get; set; }
        public decimal Rpt1InInvoiceAmt { get; set; }
        public decimal Rpt2InInvoiceAmt { get; set; }
        public decimal Rpt3InInvoiceAmt { get; set; }
        public bool NoTaxRecalc { get; set; }

        public virtual ICollection<PodetailMiscTax> PodetailMiscTax { get; set; }
    }
}
