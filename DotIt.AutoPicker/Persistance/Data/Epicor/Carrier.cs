using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Carrier
    {
        public string Company { get; set; }
        public string Carrier1 { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Scac { get; set; }
        public bool GlobalCarrier { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
