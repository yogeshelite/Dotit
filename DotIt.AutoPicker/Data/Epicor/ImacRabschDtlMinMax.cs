using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacRabschDtlMinMax
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RabschDtlMinMaxId { get; set; }
        public decimal RabschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschDtlRatesId { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal BschDtlId { get; set; }
        public decimal BschDtlRatesId { get; set; }
        public decimal BschDtlMinMaxId { get; set; }
        public string Lbfreq { get; set; }
        public int LbnoPeriod { get; set; }
        public bool LbwithinPeriod { get; set; }
        public string MinFreq { get; set; }
        public int MinNoPeriod { get; set; }
        public string MaxFreq { get; set; }
        public int MaxNoPeriod { get; set; }
        public decimal MinAmt { get; set; }
        public decimal MaxAmt { get; set; }
        public decimal MinPct { get; set; }
        public decimal MaxPct { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public decimal Raid { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public int ServicePlanId { get; set; }
    }
}
