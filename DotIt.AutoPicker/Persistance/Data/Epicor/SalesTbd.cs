using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SalesTbd
    {
        public string Company { get; set; }
        public string TerritoryId { get; set; }
        public int CountryNum { get; set; }
        public string CountryName { get; set; }
        public string State { get; set; }
        public string StartZip { get; set; }
        public string EndZip { get; set; }
        public bool GlobalSalesTbd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
