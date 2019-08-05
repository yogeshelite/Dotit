using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LicenseTenant
    {
        public Guid InstallationId { get; set; }
        public string TenantId { get; set; }
        public bool IsActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
