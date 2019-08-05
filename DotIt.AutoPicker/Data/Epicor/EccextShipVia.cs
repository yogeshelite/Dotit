using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EccextShipVia
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipViaCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Customer C { get; set; }
        public virtual ShipVia ShipVia { get; set; }
    }
}
