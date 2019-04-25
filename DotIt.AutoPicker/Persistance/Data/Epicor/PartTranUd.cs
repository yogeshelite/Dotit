using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartTranUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public int JobInvRecdQtyC { get; set; }

        public virtual PartTran ForeignSysRow { get; set; }
    }
}
