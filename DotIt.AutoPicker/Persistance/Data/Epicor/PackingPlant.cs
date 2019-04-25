using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PackingPlant
    {
        public string Company { get; set; }
        public string PkgCode { get; set; }
        public string Plant { get; set; }
        public string PkgCodePartNum { get; set; }
        public bool TrackReturnable { get; set; }
        public string TrackingReasonCodeIn { get; set; }
        public string TrackingReasonCodeOut { get; set; }
        public bool TrackExpendable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Packing Packing { get; set; }
    }
}
