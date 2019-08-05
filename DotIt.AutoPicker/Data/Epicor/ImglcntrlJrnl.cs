﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglcntrlJrnl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public string GlcontrolCode { get; set; }
        public string JrnlContext { get; set; }
        public string JournalCode { get; set; }
        public bool GlobalGlcntrlJrnl { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
