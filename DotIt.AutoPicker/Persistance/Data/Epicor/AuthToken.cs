using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AuthToken
    {
        public AuthToken()
        {
            AuthTokenClient = new HashSet<AuthTokenClient>();
        }

        public string TokenId { get; set; }
        public bool Enabled { get; set; }
        public string SignKey { get; set; }
        public int DefaultLifeTime { get; set; }
        public bool RefreshTokenSupported { get; set; }
        public int ResfreshTokenLifeTime { get; set; }
        public string Settings { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<AuthTokenClient> AuthTokenClient { get; set; }
    }
}
