using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SessionState
    {
        public Guid SessionId { get; set; }
        public string UserId { get; set; }
        public Guid SessionType { get; set; }
        public Guid InstallationId { get; set; }
        public DateTime LicenseExpirationTime { get; set; }
        public byte[] State { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
