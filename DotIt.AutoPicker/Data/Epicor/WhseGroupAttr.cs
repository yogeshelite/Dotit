using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhseGroupAttr
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string AttrCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
