﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTaxJuris
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string TaxId { get; set; }
        public string TaxJurisCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaxJurisCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxJuris { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}