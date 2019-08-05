using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Pesunatdtl
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int LineNum { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
