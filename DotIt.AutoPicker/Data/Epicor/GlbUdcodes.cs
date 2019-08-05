using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbUdcodes
    {
        public string CodeDesc { get; set; }
        public string CodeId { get; set; }
        public string CodeTypeId { get; set; }
        public string Company { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool IsActive { get; set; }
        public string LongDesc { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCodeTypeId { get; set; }
        public string GlbCodeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalUdcodes { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
