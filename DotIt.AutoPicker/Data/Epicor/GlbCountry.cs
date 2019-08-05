using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCountry
    {
        public string AptaxRegionCode { get; set; }
        public string BorderCrossing { get; set; }
        public string Company { get; set; }
        public int CountryNum { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string FiscalCode { get; set; }
        public string FormatStr { get; set; }
        public string Isocode { get; set; }
        public string IsorigCountry { get; set; }
        public string IstatCode { get; set; }
        public string LangNameId { get; set; }
        public string MxcountryCode { get; set; }
        public string ShipViaCode { get; set; }
        public string TaxRegionCode { get; set; }
        public string GlbCompany { get; set; }
        public int GlbCountryNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCountry { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agafipcode { get; set; }
        public string MxexternalCode { get; set; }
    }
}
