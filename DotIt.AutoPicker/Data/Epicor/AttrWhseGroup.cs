﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AttrWhseGroup
    {
        public string Company { get; set; }
        public string AttrCode { get; set; }
        public string AttrDescription { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
