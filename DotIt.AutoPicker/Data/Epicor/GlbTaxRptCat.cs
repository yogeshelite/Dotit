using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTaxRptCat
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string RptCatCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRptCatCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxRptCat { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
