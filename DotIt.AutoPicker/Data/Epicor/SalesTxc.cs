using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SalesTxc
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string TaxCatId { get; set; }
        public bool Reportable { get; set; }
        public string RateCode { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
