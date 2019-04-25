using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OrderRelUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string OtscontactEmailC { get; set; }
        public decimal OurShipRateC { get; set; }
        public decimal PublicShipRateC { get; set; }
        public string TrackingNumbersC { get; set; }

        public virtual OrderRel ForeignSysRow { get; set; }
    }
}
