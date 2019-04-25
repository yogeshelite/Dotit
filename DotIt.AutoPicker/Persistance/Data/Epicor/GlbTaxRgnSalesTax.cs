using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTaxRgnSalesTax
    {
        public string Company { get; set; }
        public decimal ExemptPercent { get; set; }
        public int ExemptType { get; set; }
        public string TaxCode { get; set; }
        public string TaxMethod { get; set; }
        public int TaxNum { get; set; }
        public string TaxRegionCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaxRegionCode { get; set; }
        public string GlbTaxCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxRgnSalesTax { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
