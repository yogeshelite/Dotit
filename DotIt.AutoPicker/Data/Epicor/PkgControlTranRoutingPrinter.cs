using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PkgControlTranRoutingPrinter
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string TranType { get; set; }
        public string PrinterId { get; set; }
        public int DisplaySequence { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PkgControlTranRouting PkgControlTranRouting { get; set; }
    }
}
