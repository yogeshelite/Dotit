using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VendorUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string LabelTraxxIdC { get; set; }
        public string LeadTimeC { get; set; }

        public virtual Vendor ForeignSysRow { get; set; }
    }
}
