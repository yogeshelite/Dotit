using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SalesTer
    {
        public string Company { get; set; }
        public string TerritoryId { get; set; }
        public string TerritoryDesc { get; set; }
        public string RegionCode { get; set; }
        public string Comment { get; set; }
        public bool Inactive { get; set; }
        public string PrimeSalesRepCode { get; set; }
        public string DefTaskSetId { get; set; }
        public bool ConsToPrim { get; set; }
        public string PrimeBillingTypeCd { get; set; }
        public bool GlobalSalesTer { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
