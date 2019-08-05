using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpayType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
