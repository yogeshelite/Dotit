using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipHeadUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool ShipmentEmailSentC { get; set; }
        public string SofobC { get; set; }
        public decimal OurRateC { get; set; }
        public decimal PublicRateC { get; set; }
        public bool Edi945CompleteC { get; set; }
        public string CustShipCommentC { get; set; }
        public string ShipToShipCommentC { get; set; }

        public virtual ShipHead ForeignSysRow { get; set; }
    }
}
