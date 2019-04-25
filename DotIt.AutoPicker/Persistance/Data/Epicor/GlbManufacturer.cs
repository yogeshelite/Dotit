using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbManufacturer
    {
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public string MfgId { get; set; }
        public int MfgNum { get; set; }
        public string Name { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMfgId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalManufacturer { get; set; }
        public int GlbMfgNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
