using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InvcHeadUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string EmailSentDetailsC { get; set; }
        public bool InvoiceNotificationSentC { get; set; }

        public virtual InvcHead ForeignSysRow { get; set; }
    }
}
