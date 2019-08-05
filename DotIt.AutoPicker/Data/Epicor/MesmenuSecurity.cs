using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MesmenuSecurity
    {
        public string Company { get; set; }
        public int MesmenuId { get; set; }
        public string SecurityGroup { get; set; }
        public string Role { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Mesmenu Mesmenu { get; set; }
    }
}
