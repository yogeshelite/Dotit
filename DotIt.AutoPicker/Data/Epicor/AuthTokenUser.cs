using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AuthTokenUser
    {
        public string TokenId { get; set; }
        public Guid ClientId { get; set; }
        public string UserId { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenIssued { get; set; }
        public string Settings { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual AuthTokenClient AuthTokenClient { get; set; }
    }
}
