using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSalesTer
    {
        public string Comment { get; set; }
        public string Company { get; set; }
        public bool ConsToPrim { get; set; }
        public string DefTaskSetId { get; set; }
        public bool Inactive { get; set; }
        public string PrimeBillingTypeCd { get; set; }
        public string PrimeSalesRepCode { get; set; }
        public string RegionCode { get; set; }
        public string TerritoryDesc { get; set; }
        public string TerritoryId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTerritoryId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSalesTer { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
