using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbAprvMfg
    {
        public string Company { get; set; }
        public int MfgNum { get; set; }
        public string PartNum { get; set; }
        public string GlbCompany { get; set; }
        public int GlbMfgNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalAprvMfg { get; set; }
        public bool GlobalLock { get; set; }
        public string GlbPartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
