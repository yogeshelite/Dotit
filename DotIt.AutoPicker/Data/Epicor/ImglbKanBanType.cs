using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbKanBanType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string KbactionCode { get; set; }
        public string Kbcode { get; set; }
        public string Kbdescription { get; set; }
        public bool KbmtlQueue { get; set; }
        public bool Kbrelease { get; set; }
        public string GlbCompany { get; set; }
        public string GlbKbcode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalKanBanType { get; set; }
        public bool GlobalLock { get; set; }
        public bool KbtforderSug { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
