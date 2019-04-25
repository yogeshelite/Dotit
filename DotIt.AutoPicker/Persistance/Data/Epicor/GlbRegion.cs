using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbRegion
    {
        public string Company { get; set; }
        public int CountryNum { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string RegionCode { get; set; }
        public string RegionComment { get; set; }
        public string SalesManagerId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRegionCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRegion { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
