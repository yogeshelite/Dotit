using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Manufacturer
    {
        public string Company { get; set; }
        public int MfgNum { get; set; }
        public string MfgId { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
        public bool GlobalManufacturer { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
