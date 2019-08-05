using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhseGroupBinZone
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string WarehouseCode { get; set; }
        public string ZoneId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
