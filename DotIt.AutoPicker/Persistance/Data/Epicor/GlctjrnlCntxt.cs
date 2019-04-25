using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlctjrnlCntxt
    {
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public string JrnlContext { get; set; }
        public string JournalCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
