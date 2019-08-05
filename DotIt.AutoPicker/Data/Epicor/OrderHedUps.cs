using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OrderHedUps
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int Upsqvseq { get; set; }
        public string EmailAddress { get; set; }
        public bool ShipmentNotify { get; set; }
        public bool FailureNotify { get; set; }
        public bool DeliveryNotify { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
