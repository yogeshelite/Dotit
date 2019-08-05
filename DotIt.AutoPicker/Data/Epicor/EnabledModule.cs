using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EnabledModule
    {
        public Guid InstallationId { get; set; }
        public Guid FeatureId { get; set; }
        public string FeatureName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
