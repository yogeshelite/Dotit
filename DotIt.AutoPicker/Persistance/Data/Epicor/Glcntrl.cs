using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Glcntrl
    {
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public string GlcontrolCode { get; set; }
        public string Description { get; set; }
        public bool GlobalGlcntrl { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
