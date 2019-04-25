using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysGlcntrlType
    {
        public string Company { get; set; }
        public string SysGlcontrolType { get; set; }
        public string RecordType { get; set; }
        public bool SystemType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
