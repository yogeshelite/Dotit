using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbQmarkUp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public decimal BurdenMarkUp { get; set; }
        public decimal CommissionPct { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public decimal LaborMarkUp { get; set; }
        public string MarkUpId { get; set; }
        public decimal MaterialMarkUp { get; set; }
        public decimal MiscCostMarkUp { get; set; }
        public decimal MtlBurMarkUp { get; set; }
        public string PercentType { get; set; }
        public decimal SubcontractMarkUp { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMarkUpId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalQmarkUp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
