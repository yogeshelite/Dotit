using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Faclass
    {
        public string Company { get; set; }
        public string ClassCode { get; set; }
        public string Description { get; set; }
        public bool GlobalFaclass { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
