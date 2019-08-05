using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartBinInfo
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public decimal MinimumQty { get; set; }
        public decimal MaximumQty { get; set; }
        public decimal SafetyQty { get; set; }
        public string Kbcode { get; set; }
        public int Kbponum { get; set; }
        public int Kbpoline { get; set; }
        public string KbwarehouseCode { get; set; }
        public string KbbinNum { get; set; }
        public string Kbplant { get; set; }
        public decimal OnhandQty { get; set; }
        public decimal Kbqty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
