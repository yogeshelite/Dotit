using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTariff
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public decimal MaxDutyAmt { get; set; }
        public decimal MinDutyAmt { get; set; }
        public string PrefSchemeId { get; set; }
        public decimal SpecDutyAmt { get; set; }
        public string TariffCode { get; set; }
        public decimal TariffPercent { get; set; }
        public decimal TariffRate { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTariffCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTariff { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
