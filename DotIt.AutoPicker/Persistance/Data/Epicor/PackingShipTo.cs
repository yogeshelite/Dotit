using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PackingShipTo
    {
        public string Company { get; set; }
        public string PkgCode { get; set; }
        public int ShipToSeq { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string ShipToContainerPartId { get; set; }
        public string ShipToContainerPartDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Packing Packing { get; set; }
    }
}
