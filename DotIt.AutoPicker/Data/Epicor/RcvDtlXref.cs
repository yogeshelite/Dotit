using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RcvDtlXref
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public int RcvXrefNum { get; set; }
        public string VendPartNum { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public bool Received { get; set; }
        public bool Invoiced { get; set; }
        public bool Inspected { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
