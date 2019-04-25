using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbFinChargeRate
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string ChargeCode { get; set; }
        public decimal ChargePercent { get; set; }
        public int ChargePeriod { get; set; }
        public string Company { get; set; }
        public int DaysNum { get; set; }
        public DateTime? EffDate { get; set; }
        public string GlbCompany { get; set; }
        public string GlbChargeCode { get; set; }
        public DateTime? GlbEffDate { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFinChargeRate { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
