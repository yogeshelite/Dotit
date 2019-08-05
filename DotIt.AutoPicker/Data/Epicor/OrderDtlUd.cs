using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OrderDtlUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public int ShipBoxNumberC { get; set; }
        public decimal BoxWeightC { get; set; }
        public decimal NetWeightC { get; set; }
        public string OriginalOrderLineC { get; set; }
        public string PartShipCommentC { get; set; }

        public virtual OrderDtl ForeignSysRow { get; set; }
    }
}
