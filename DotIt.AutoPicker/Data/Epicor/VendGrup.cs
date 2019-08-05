using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendGrup
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public bool GlobalVendGrup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
