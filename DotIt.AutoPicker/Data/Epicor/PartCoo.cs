using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartCoo
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public int OrigCountry { get; set; }
        public int QtyPerc { get; set; }
        public int ValuePerc { get; set; }
        public bool Primary { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
