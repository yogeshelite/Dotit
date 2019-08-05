using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcserviceSchedDtlOthRes
    {
        public string Company { get; set; }
        public int ServicePlanId { get; set; }
        public int ServicePlanDtlId { get; set; }
        public int SchedId { get; set; }
        public int SchedDtlId { get; set; }
        public int SchedDtlOthResId { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
