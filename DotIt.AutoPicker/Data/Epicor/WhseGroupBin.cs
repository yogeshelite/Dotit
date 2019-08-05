using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhseGroupBin
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
