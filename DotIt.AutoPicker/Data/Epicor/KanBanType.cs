using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class KanBanType
    {
        public string Company { get; set; }
        public string Kbcode { get; set; }
        public string Kbdescription { get; set; }
        public string KbactionCode { get; set; }
        public bool KbmtlQueue { get; set; }
        public bool Kbrelease { get; set; }
        public bool GlobalKanBanType { get; set; }
        public bool GlobalLock { get; set; }
        public bool KbtforderSug { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
