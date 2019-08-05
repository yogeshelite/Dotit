using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbRefCategory
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string Prefix { get; set; }
        public string RefCategory { get; set; }
        public string Suffix { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRefCategory1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRefCategory { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
