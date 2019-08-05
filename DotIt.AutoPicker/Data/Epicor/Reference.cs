using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Reference
    {
        public int RefUid { get; set; }
        public string RefCode { get; set; }
        public string RefValue { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
