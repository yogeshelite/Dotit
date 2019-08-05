using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PasswordPolicy
    {
        public string TenantId { get; set; }
        public int MinimumPasswordLength { get; set; }
        public bool CanIncludeUserId { get; set; }
        public bool CanIncludeUserNamePortion { get; set; }
        public bool CanSavePassword { get; set; }
        public int UserNameMatchLength { get; set; }
        public bool RequireLowercaseCharacter { get; set; }
        public bool RequireUppercaseCharacter { get; set; }
        public bool RequireDigitCharacter { get; set; }
        public bool RequireSpecialCharacter { get; set; }
        public int MinimumCharacterTypes { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AllowBlankPassword { get; set; }
    }
}
