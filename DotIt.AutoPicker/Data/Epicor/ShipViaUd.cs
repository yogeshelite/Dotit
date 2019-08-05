using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShipViaUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool ExpediteShippingC { get; set; }

        public virtual ShipVia ForeignSysRow { get; set; }
    }
}
