using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbEquipType
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public string TypeId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTypeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalEquipType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
