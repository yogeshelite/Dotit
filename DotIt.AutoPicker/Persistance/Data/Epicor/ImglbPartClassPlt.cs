using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPartClassPlt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
