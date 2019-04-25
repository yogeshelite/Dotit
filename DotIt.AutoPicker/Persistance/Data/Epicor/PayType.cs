using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PayType
    {
        public string Company { get; set; }
        public string PayTypeId { get; set; }
        public string Description { get; set; }
        public decimal PremiumFactor { get; set; }
        public bool UseSuppPct { get; set; }
        public bool IncludeShift { get; set; }
        public bool PayDifferentials { get; set; }
        public string ExemptTaxes { get; set; }
        public bool Otadd { get; set; }
        public string IncomeTaxCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
