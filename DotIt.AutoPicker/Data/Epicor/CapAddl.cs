using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CapAddl
    {
        public string Company { get; set; }
        public string CapabilityId { get; set; }
        public string CapAddId { get; set; }
        public string Description { get; set; }
        public bool ProductionCap { get; set; }
        public bool SetupCap { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
