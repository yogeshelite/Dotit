using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlcntrlJrnl
    {
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public string GlcontrolCode { get; set; }
        public string JrnlContext { get; set; }
        public string JournalCode { get; set; }
        public bool GlobalGlcntrlJrnl { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
