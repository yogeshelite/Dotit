using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcserviceSched
    {
        public string Company { get; set; }
        public int ServicePlanId { get; set; }
        public int ServicePlanDtlId { get; set; }
        public int SchedId { get; set; }
        public string SchedType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int EveryNdays { get; set; }
        public int EveryNweeks { get; set; }
        public int EveryNmonths { get; set; }
        public int EveryNyears { get; set; }
        public int EndOccurence { get; set; }
        public DateTime? LastSchedDate { get; set; }
        public bool Inactive { get; set; }
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
