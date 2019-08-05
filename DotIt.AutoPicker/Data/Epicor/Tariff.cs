using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Tariff
    {
        public string Company { get; set; }
        public string TariffCode { get; set; }
        public string Description { get; set; }
        public string PrefSchemeId { get; set; }
        public decimal TariffRate { get; set; }
        public decimal TariffPercent { get; set; }
        public decimal SpecDutyAmt { get; set; }
        public decimal MinDutyAmt { get; set; }
        public decimal MaxDutyAmt { get; set; }
        public bool GlobalTariff { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
