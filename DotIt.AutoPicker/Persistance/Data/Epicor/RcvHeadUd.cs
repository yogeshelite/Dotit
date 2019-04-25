using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RcvHeadUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string FreightTermsC { get; set; }

        public virtual RcvHead ForeignSysRow { get; set; }
    }
}
