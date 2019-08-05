using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCarrier
    {
        public bool Active { get; set; }
        public string Carrier { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Scac { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCarrier1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCarrier { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
