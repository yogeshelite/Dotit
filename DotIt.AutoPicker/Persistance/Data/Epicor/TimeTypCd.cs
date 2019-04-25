using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TimeTypCd
    {
        public string Company { get; set; }
        public string TimeTypCd1 { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool GlobalTimeTypCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
