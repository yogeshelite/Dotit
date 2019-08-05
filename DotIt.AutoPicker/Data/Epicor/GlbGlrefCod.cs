﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbGlrefCod
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string RefType { get; set; }
        public string RefCode { get; set; }
        public string RefCodeDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
