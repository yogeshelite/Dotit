using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTaxText
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string TextCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTextCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
