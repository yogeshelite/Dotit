using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SpecHed
    {
        public string Company { get; set; }
        public string SpecType { get; set; }
        public string SpecId { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool GlobalSpecHed { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
