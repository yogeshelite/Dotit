using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PackClss
    {
        public string Company { get; set; }
        public string PkgClass { get; set; }
        public string Description { get; set; }
        public decimal PkgLength { get; set; }
        public decimal PkgWidth { get; set; }
        public decimal PkgHeight { get; set; }
        public bool GlobalPackClss { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
