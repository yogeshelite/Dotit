using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShipDtlUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string PartShipCommentC { get; set; }

        public virtual ShipDtl ForeignSysRow { get; set; }
    }
}
