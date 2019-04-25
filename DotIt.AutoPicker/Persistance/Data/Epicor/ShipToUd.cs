using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipToUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string UpsvalidatedC { get; set; }
        public string UspsvalidatedC { get; set; }
        public bool InactiveC { get; set; }
        public string ShipToCommentsC { get; set; }

        public virtual ShipTo ForeignSysRow { get; set; }
    }
}
