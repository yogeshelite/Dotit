using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SalesTrp
    {
        public string Company { get; set; }
        public string TerritoryId { get; set; }
        public string SalesRepCode { get; set; }
        public string Name { get; set; }
        public string RoleCode { get; set; }
        public bool GlobalSalesTrp { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
