using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EquipType
    {
        public string Company { get; set; }
        public string TypeId { get; set; }
        public bool InActive { get; set; }
        public string Description { get; set; }
        public bool GlobalEquipType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
