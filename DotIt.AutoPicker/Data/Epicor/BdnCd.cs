using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BdnCd
    {
        public string Company { get; set; }
        public string BdnCd1 { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public bool UseAllPrjRole { get; set; }
        public bool GlobalBdnCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
