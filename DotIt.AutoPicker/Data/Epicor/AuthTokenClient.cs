using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AuthTokenClient
    {
        public AuthTokenClient()
        {
            AuthTokenUser = new HashSet<AuthTokenUser>();
        }

        public string TokenId { get; set; }
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
        public int? TokenLifeTime { get; set; }
        public bool? RefreshTokenSupported { get; set; }
        public int? ResfreshTokenLifeTime { get; set; }
        public string Settings { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual AuthToken Token { get; set; }
        public virtual ICollection<AuthTokenUser> AuthTokenUser { get; set; }
    }
}
