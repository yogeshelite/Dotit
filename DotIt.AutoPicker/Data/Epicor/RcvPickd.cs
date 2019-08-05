using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RcvPickd
    {
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public bool Picked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
