using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSalesTax
    {
        public bool Advanced { get; set; }
        public string Algorithm { get; set; }
        public int CollectionType { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Direct { get; set; }
        public int DiscountType { get; set; }
        public int Etchash { get; set; }
        public string EtcjurisKey { get; set; }
        public bool InPrice { get; set; }
        public decimal LglNumSeq { get; set; }
        public int LglNumType { get; set; }
        public bool Manual { get; set; }
        public string RevRptCatCode { get; set; }
        public bool RoundDown { get; set; }
        public string RptCatCode { get; set; }
        public bool ServiceTaxPoint { get; set; }
        public string TaxCode { get; set; }
        public bool TaxConnectCalc { get; set; }
        public string TaxJurisCode { get; set; }
        public string TextCode { get; set; }
        public int Timing { get; set; }
        public string Triangulation { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaxCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSalesTax { get; set; }
        public string CustType { get; set; }
        public string InvMethod { get; set; }
        public string InvoiceType { get; set; }
        public string IssueType { get; set; }
        public string RevType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SendToFsa { get; set; }
        public int TimingDepositAdvBilling { get; set; }
    }
}
