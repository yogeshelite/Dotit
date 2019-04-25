using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IdentityProvider
    {
        public string ProviderId { get; set; }
        public string Endpoint { get; set; }
        public bool Enabled { get; set; }
        public string TokenValidationApiScope { get; set; }
        public string NativeClientId { get; set; }
        public string WebClientId { get; set; }
        public bool ScimExportEnabled { get; set; }
        public string ScimClientId { get; set; }
        public string ScimClientSecret { get; set; }
        public string ScimApiScope { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
