using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhseGroupItem
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string WarehouseCode { get; set; }
        public string ItemClass { get; set; }
        public string ItemCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
