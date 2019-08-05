using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxRgn
    {
        public string Company { get; set; }
        public string TaxRegionCode { get; set; }
        public string Description { get; set; }
        public bool InEc { get; set; }
        public bool TaxConnectCalc { get; set; }
        public bool UseInAp { get; set; }
        public bool UseInAr { get; set; }
        public bool EuthirdParty { get; set; }
        public bool InPrice { get; set; }
        public bool GlobalTaxRgn { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string IntaxLiabilityType { get; set; }
        public bool Indefault { get; set; }
        public string RetTaxRgnCode { get; set; }
        public bool NonTaxableDep { get; set; }
        public bool IsReturn { get; set; }
        public string JpconsumptionTaxType { get; set; }
        public bool CalcTaxIc { get; set; }
        public string CospecialTaxRegime { get; set; }
    }
}
