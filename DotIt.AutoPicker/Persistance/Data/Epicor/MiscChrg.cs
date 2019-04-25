using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MiscChrg
    {
        public string Company { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public string FreqCode { get; set; }
        public decimal MiscAmt { get; set; }
        public string TaxCatId { get; set; }
        public bool ShippingAccess { get; set; }
        public bool SalesAnalysis { get; set; }
        public string Ischarge { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool GlobalMiscChrg { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeDiscount { get; set; }
        public string MxprodServCode { get; set; }
        public bool SendToFsa { get; set; }
    }
}
