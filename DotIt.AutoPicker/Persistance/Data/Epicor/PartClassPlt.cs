using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartClassPlt
    {
        public string Company { get; set; }
        public string ClassId { get; set; }
        public string OwnerPlant { get; set; }
        public int ReceiveTime { get; set; }
        public int PlanTimeFence { get; set; }
        public int ReschedOutDelta { get; set; }
        public int ReschedInDelta { get; set; }
        public bool GlobalPartClassPlt { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
