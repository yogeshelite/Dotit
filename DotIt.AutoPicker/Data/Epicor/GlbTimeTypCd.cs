using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTimeTypCd
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public string TimeTypCd { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTimeTypCd1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTimeTypCd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
