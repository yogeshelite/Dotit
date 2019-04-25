using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxTextD
    {
        public string Company { get; set; }
        public string TextCode { get; set; }
        public string LangNameId { get; set; }
        public string LegalText { get; set; }
        public bool TextDefault { get; set; }
        public bool GlobalTaxTextD { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
