using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartXrefVend
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public int VendorNum { get; set; }
        public string VendPartNum { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public string Reference { get; set; }
        public int LeadTime { get; set; }
        public bool PurchaseDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
