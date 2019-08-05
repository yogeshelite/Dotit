using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RmaheadUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string UserIdC { get; set; }

        public virtual Rmahead ForeignSysRow { get; set; }
    }
}
