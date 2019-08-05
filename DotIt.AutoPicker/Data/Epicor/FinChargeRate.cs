using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FinChargeRate
    {
        public string Company { get; set; }
        public string ChargeCode { get; set; }
        public DateTime? EffDate { get; set; }
        public decimal ChargePercent { get; set; }
        public int DaysNum { get; set; }
        public int ChargePeriod { get; set; }
        public bool GlobalFinChargeRate { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
