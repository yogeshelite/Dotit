using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysUserCompExt
    {
        public string UserId { get; set; }
        public string Company { get; set; }
        public string ExtCompId { get; set; }
        public string Name { get; set; }
        public string CurPlant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysUserComp SysUserComp { get; set; }
    }
}
