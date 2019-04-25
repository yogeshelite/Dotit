using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SalesTax
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string Description { get; set; }
        public bool Manual { get; set; }
        public bool RoundDown { get; set; }
        public bool Advanced { get; set; }
        public bool TaxConnectCalc { get; set; }
        public string EtcjurisKey { get; set; }
        public int Etchash { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public string Algorithm { get; set; }
        public int DiscountType { get; set; }
        public string TaxJurisCode { get; set; }
        public string RptCatCode { get; set; }
        public string TextCode { get; set; }
        public bool InPrice { get; set; }
        public int LglNumType { get; set; }
        public decimal LglNumSeq { get; set; }
        public string RevRptCatCode { get; set; }
        public bool ServiceTaxPoint { get; set; }
        public string Direct { get; set; }
        public string Triangulation { get; set; }
        public bool GlobalSalesTax { get; set; }
        public bool GlobalLock { get; set; }
        public string InvoiceType { get; set; }
        public string InvMethod { get; set; }
        public string CustType { get; set; }
        public string RevType { get; set; }
        public string IssueType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool InisCst { get; set; }
        public string Agafipcode { get; set; }
        public string AgafiptaxRegCode { get; set; }
        public string AgafiptaxRegDesc { get; set; }
        public bool AgminimumByTax { get; set; }
        public string AgtaxableAmtType { get; set; }
        public string Agwhheader { get; set; }
        public string IndirectTaxType { get; set; }
        public string MxtaxCategory { get; set; }
        public string NotaxCategory { get; set; }
        public string PetranDocTypeId { get; set; }
        public string PetaxOriginType { get; set; }
        public string Mxsatcode { get; set; }
        public string Pesunatcode { get; set; }
        public string Pesunatname { get; set; }
        public string Pesunattype { get; set; }
        public string Plsaftcode { get; set; }
        public string MxtaxType { get; set; }
        public string MxtypeFactor { get; set; }
        public bool SendToFsa { get; set; }
        public int TimingDepositAdvBilling { get; set; }
    }
}
