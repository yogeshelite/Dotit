using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxJuris
    {
        public string Company { get; set; }
        public string TaxJurisCode { get; set; }
        public string Description { get; set; }
        public string TaxId { get; set; }
        public bool GlobalTaxJuris { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
