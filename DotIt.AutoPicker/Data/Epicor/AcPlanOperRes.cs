using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcPlanOperRes
    {
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int PlanNum { get; set; }
        public int OprSeq { get; set; }
        public int ResSeq { get; set; }
        public string ResourceId { get; set; }
        public string ResourceGrpId { get; set; }
        public string CapabilityId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
