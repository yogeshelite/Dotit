using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TwguivendDfltDocType
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceType { get; set; }
        public string TranDocType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
