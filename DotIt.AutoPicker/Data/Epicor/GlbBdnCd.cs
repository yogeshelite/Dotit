using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbBdnCd
    {
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public string BdnCd { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool UseAllPrjRole { get; set; }
        public string GlbCompany { get; set; }
        public string GlbBdnCd1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalBdnCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
