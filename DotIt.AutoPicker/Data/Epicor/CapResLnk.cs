﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CapResLnk
    {
        public string Company { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceId { get; set; }
        public int ResourcePriority { get; set; }
        public decimal ProductionFactor { get; set; }
        public decimal SetupFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
