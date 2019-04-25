using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Jcdept
    {
        public string Company { get; set; }
        public string Jcdept1 { get; set; }
        public string Description { get; set; }
        public bool GlobalJcdept { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
