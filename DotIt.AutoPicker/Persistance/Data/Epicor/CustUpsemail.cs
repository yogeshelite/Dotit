using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustUpsemail
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int Upsqvseq { get; set; }
        public string EmailAddress { get; set; }
        public bool ShipmentNotify { get; set; }
        public bool FailureNotify { get; set; }
        public bool DeliveryNotify { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
