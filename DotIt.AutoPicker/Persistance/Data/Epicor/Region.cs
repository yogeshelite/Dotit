using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Region
    {
        public string Company { get; set; }
        public string RegionCode { get; set; }
        public string Description { get; set; }
        public int CountryNum { get; set; }
        public bool Inactive { get; set; }
        public string RegionComment { get; set; }
        public string SalesManagerId { get; set; }
        public bool GlobalRegion { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
