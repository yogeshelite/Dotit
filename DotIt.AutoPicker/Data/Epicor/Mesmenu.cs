using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Mesmenu
    {
        public Mesmenu()
        {
            MesmenuSecurity = new HashSet<MesmenuSecurity>();
        }

        public string Company { get; set; }
        public int MesmenuId { get; set; }
        public int? ParentMesmenuId { get; set; }
        public string MenuType { get; set; }
        public int Seq { get; set; }
        public string MenuId { get; set; }
        public string MenuDesc { get; set; }
        public bool Hidden { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<MesmenuSecurity> MesmenuSecurity { get; set; }
    }
}
