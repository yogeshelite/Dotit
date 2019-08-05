using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteCst
    {
        public int QtyNum { get; set; }
        public decimal TotalMtlCost { get; set; }
        public decimal TotalLbrCost { get; set; }
        public decimal TotalBurCost { get; set; }
        public decimal TotalSubCost { get; set; }
        public decimal TotalMtlBurCost { get; set; }
        public decimal TotalSetupLbrHrs { get; set; }
        public decimal TotalSetupBurHrs { get; set; }
        public decimal TotalProdLbrHrs { get; set; }
        public decimal TotalProdBurHrs { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
