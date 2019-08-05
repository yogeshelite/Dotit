﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imtariff
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
