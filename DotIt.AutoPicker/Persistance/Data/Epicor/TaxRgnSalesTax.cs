using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxRgnSalesTax
    {
        public string Company { get; set; }
        public string TaxRegionCode { get; set; }
        public string TaxCode { get; set; }
        public string TaxMethod { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public int TaxNum { get; set; }
        public bool GlobalTaxRgnSalesTax { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
