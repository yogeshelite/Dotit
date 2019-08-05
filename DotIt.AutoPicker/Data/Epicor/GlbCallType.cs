using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCallType
    {
        public string CallTypeCode { get; set; }
        public string CallTypeDesc { get; set; }
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCallTypeCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCallType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
