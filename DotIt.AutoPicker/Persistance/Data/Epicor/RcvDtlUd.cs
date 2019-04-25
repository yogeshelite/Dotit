using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RcvDtlUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public decimal PartHeightC { get; set; }
        public decimal PartLengthC { get; set; }
        public decimal PartWidthC { get; set; }

        public virtual RcvDtl ForeignSysRow { get; set; }
    }
}
