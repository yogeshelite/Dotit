using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Whsebinattr
    {
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string AttrCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
