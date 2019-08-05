using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbSkipLotCtl
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public int InspectLot { get; set; }
        public int MaxRejects { get; set; }
        public int MinCycles { get; set; }
        public string OnFailSkipCd { get; set; }
        public string OnPassSkipCd { get; set; }
        public string RejectCntBy { get; set; }
        public int RepeatLots { get; set; }
        public string SkipCode { get; set; }
        public int SkipLots { get; set; }
        public bool UseMaxRejects { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSkipCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSkipLotCtl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
