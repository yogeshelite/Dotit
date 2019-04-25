using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OrderHedUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string OrderTypeC { get; set; }
        public string OtscontactEmailC { get; set; }
        public bool MossProcessC { get; set; }
        public int JoboridC { get; set; }
        public int JobidC { get; set; }
        public decimal OurShipRateC { get; set; }
        public decimal PublicShipRateC { get; set; }
        public decimal TotalWgtC { get; set; }
        public bool MopsC { get; set; }
        public DateTime? OrderTimeC { get; set; }
        public bool FreeShippingC { get; set; }
        public string CustShipCommentC { get; set; }
        public string ShipToShipCommentC { get; set; }

        public virtual OrderHed ForeignSysRow { get; set; }
    }
}
