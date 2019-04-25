using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProjChkLstType
    {
        public string TypeId { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public bool GlobalProjChkLstType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
