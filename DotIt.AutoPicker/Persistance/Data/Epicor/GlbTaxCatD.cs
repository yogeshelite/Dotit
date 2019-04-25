using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTaxCatD
    {
        public string Company { get; set; }
        public string RateCode { get; set; }
        public string TaxCatId { get; set; }
        public string TaxCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaxCatId { get; set; }
        public string GlbTaxCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxCatD { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
