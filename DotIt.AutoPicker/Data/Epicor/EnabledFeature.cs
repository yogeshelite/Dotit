using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EnabledFeature
    {
        public Guid FeatureId { get; set; }
        public int Level { get; set; }
        public string Target { get; set; }
        public string TenantId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
