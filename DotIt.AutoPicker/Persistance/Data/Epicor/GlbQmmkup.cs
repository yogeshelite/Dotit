using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbQmmkup
    {
        public string ClassCode { get; set; }
        public string Company { get; set; }
        public string MarkUpId { get; set; }
        public decimal MaterialMarkUp { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMarkUpId { get; set; }
        public string GlbClassCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalQmmkup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
