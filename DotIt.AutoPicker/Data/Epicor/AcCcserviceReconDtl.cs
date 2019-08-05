using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcserviceReconDtl
    {
        public string Company { get; set; }
        public int ServiceReconId { get; set; }
        public int ServiceReconDtlId { get; set; }
        public int ServiceDtlId { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public int PlanStartTime { get; set; }
        public int PlanEndTime { get; set; }
        public int PlanHours { get; set; }
        public int PlanMinutes { get; set; }
        public decimal PlanQty { get; set; }
        public decimal PlanRate { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActEndDate { get; set; }
        public int ActStartTime { get; set; }
        public int ActEndTime { get; set; }
        public int ActHours { get; set; }
        public int ActMinutes { get; set; }
        public decimal ActQty { get; set; }
        public decimal ActRate { get; set; }
        public string Ium { get; set; }
        public string UnitType { get; set; }
        public DateTime? AdjStartDate { get; set; }
        public DateTime? AdjEndDate { get; set; }
        public int AdjStartTime { get; set; }
        public int AdjEndTime { get; set; }
        public int AdjHours { get; set; }
        public int AdjMinutes { get; set; }
        public decimal AdjQty { get; set; }
        public decimal AdjRate { get; set; }
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
