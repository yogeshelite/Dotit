using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImskipLotCtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SkipCode { get; set; }
        public string Description { get; set; }
        public int InspectLot { get; set; }
        public int SkipLots { get; set; }
        public int RepeatLots { get; set; }
        public int MinCycles { get; set; }
        public int MaxRejects { get; set; }
        public string RejectCntBy { get; set; }
        public string OnPassSkipCd { get; set; }
        public string OnFailSkipCd { get; set; }
        public bool UseMaxRejects { get; set; }
        public bool GlobalSkipLotCtl { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
