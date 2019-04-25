using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ControlId
    {
        public ControlId()
        {
            ControlIdsegment = new HashSet<ControlIdsegment>();
        }

        public string Company { get; set; }
        public string ControlIdcode { get; set; }
        public string ControlIddesc { get; set; }
        public string ControlIdtype { get; set; }
        public string RangeFrom { get; set; }
        public string RangeTo { get; set; }
        public bool InUse { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ControlIdsegment> ControlIdsegment { get; set; }
    }
}
