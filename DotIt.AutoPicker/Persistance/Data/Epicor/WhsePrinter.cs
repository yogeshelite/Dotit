using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhsePrinter
    {
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string PrinterId { get; set; }
        public bool IsDefaultPrinter { get; set; }
        public int DisplaySeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Warehse Warehse { get; set; }
    }
}
