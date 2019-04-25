using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Lifecycle
    {
        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool DefaultStatus { get; set; }
        public bool Inactive { get; set; }
        public bool GlobalLifecycle { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
