using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPrjMkUp
    {
        public string Company { get; set; }
        public string MarkUpId { get; set; }
        public decimal PrjRoleMarkUp { get; set; }
        public string RoleCd { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMarkUpId { get; set; }
        public string GlbRoleCd { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPrjMkUp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
