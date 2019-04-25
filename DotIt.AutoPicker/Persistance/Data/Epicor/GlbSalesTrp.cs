using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSalesTrp
    {
        public string Company { get; set; }
        public string Name { get; set; }
        public string RoleCode { get; set; }
        public string SalesRepCode { get; set; }
        public string TerritoryId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTerritoryId { get; set; }
        public string GlbSalesRepCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSalesTrp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
