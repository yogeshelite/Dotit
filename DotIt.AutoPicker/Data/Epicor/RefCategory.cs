using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RefCategory
    {
        public string Company { get; set; }
        public string RefCategory1 { get; set; }
        public string Description { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public bool GlobalRefCategory { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
