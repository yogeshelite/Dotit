using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SystemQuerySecurityOverride
    {
        public string TenantId { get; set; }
        public string QueryId { get; set; }
        public string SecCodeOverride { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
