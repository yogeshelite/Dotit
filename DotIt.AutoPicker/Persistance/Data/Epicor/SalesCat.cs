using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SalesCat
    {
        public string Company { get; set; }
        public string SalesCatId { get; set; }
        public string Description { get; set; }
        public string Gldept { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
