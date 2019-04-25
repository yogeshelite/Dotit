using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbEquipStatus
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public string StatusId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbStatusId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalEquipStatus { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
