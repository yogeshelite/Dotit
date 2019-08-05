using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbProjChkLstType
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTypeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalProjChkLstType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
