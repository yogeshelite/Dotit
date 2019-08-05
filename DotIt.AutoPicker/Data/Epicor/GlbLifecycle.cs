using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbLifecycle
    {
        public string Code { get; set; }
        public string Company { get; set; }
        public bool DefaultStatus { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLifecycle { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
