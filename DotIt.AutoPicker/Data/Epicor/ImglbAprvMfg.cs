﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbAprvMfg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int MfgNum { get; set; }
        public string PartNum { get; set; }
        public string GlbCompany { get; set; }
        public int GlbMfgNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalAprvMfg { get; set; }
        public bool GlobalLock { get; set; }
        public string GlbPartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
