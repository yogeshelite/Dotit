using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PkgControlTranRouting
    {
        public PkgControlTranRouting()
        {
            PkgControlTranRoutingPrinter = new HashSet<PkgControlTranRoutingPrinter>();
        }

        public string Company { get; set; }
        public string Plant { get; set; }
        public string TranType { get; set; }
        public string TranTypeDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<PkgControlTranRoutingPrinter> PkgControlTranRoutingPrinter { get; set; }
    }
}
