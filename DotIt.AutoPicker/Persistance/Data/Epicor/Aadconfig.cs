using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Aadconfig
    {
        public string DirectoryId { get; set; }
        public string WebAppId { get; set; }
        public string TenantId { get; set; }
        public string Description { get; set; }
        public string NativeClientAppId { get; set; }
        public string ClaimName { get; set; }
        public bool UseAsDefaultApp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
