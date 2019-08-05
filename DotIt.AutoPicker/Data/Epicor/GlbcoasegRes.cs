﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbcoasegRes
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public string SegmentCode { get; set; }
        public string RestrictId { get; set; }
        public string RestrictText { get; set; }
        public bool FctBlocked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
