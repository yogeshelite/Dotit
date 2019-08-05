using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteHedUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string OrderTypeC { get; set; }

        public virtual QuoteHed ForeignSysRow { get; set; }
    }
}
