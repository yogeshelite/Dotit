using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysGlctacctCntxt
    {
        public string Company { get; set; }
        public string SysGlcontrolType { get; set; }
        public string SysGlacctContext { get; set; }
        public string RecordType { get; set; }
        public bool SystemCntxt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
