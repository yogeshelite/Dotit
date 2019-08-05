using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PriceLstUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool ExpiredC { get; set; }

        public virtual PriceLst ForeignSysRow { get; set; }
    }
}
