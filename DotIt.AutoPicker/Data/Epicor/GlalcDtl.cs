﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlalcDtl
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public int AllocLine { get; set; }
        public decimal AllocationUnits { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
