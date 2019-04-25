using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EquipStatus
    {
        public string Company { get; set; }
        public string StatusId { get; set; }
        public bool InActive { get; set; }
        public string Description { get; set; }
        public bool GlobalEquipStatus { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
