using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbAttribut
    {
        public string AttrCode { get; set; }
        public string AttrDescription { get; set; }
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public string GlbCompany { get; set; }
        public string GlbAttrCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalAttribut { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
