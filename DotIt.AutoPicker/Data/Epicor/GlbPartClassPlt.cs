using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPartClassPlt
    {
        public string ClassId { get; set; }
        public string Company { get; set; }
        public string OwnerPlant { get; set; }
        public int PlanTimeFence { get; set; }
        public int ReceiveTime { get; set; }
        public int ReschedInDelta { get; set; }
        public int ReschedOutDelta { get; set; }
        public string GlbCompany { get; set; }
        public string GlbClassId { get; set; }
        public string GlbOwnerPlant { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPartClassPlt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
