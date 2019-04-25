using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhseGroupWhse
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string WarehouseCode { get; set; }
        public int TransPriority { get; set; }
        public string ItemType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
