using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCustGrup
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public string SalesCatId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbGroupCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCustGrup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
