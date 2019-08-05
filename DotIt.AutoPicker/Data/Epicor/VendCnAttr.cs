using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendCnAttr
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string AttrCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
