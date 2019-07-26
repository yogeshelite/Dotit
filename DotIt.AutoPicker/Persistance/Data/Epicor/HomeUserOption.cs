using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HomeUserOption
    {
        public string UserId { get; set; }
        public string HomePageType { get; set; }
        public string SubType { get; set; }
        public string ShellUserOptions { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysUserFile User { get; set; }
    }
}
