using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Edihist
    {
        public string Company { get; set; }
        public string DocType { get; set; }
        public int DocNum { get; set; }
        public int LineNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
