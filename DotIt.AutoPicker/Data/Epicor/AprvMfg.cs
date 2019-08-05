using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AprvMfg
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public int MfgNum { get; set; }
        public bool GlobalAprvMfg { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
