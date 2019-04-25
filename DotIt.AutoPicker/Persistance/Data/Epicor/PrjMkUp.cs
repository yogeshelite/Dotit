using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrjMkUp
    {
        public string Company { get; set; }
        public string MarkUpId { get; set; }
        public string RoleCd { get; set; }
        public decimal PrjRoleMarkUp { get; set; }
        public bool GlobalPrjMkUp { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
