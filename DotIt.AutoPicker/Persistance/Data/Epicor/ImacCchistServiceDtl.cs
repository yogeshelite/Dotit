using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacCchistServiceDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ServiceDtlId { get; set; }
        public int ServicePlanId { get; set; }
        public int ServicePlanDtlId { get; set; }
        public int SchedId { get; set; }
        public int SchedDtlId { get; set; }
        public int SchedDtlOthResId { get; set; }
        public int CustNum { get; set; }
        public int CallNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public string OpCode { get; set; }
        public string OpDesc { get; set; }
        public string Capability { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
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
        public bool NonBillable { get; set; }
        public string AddressType { get; set; }
        public string ServiceStatus { get; set; }
        public string JobOprStatus { get; set; }
        public string FscallStatus { get; set; }
        public string Remark { get; set; }
        public string Notes { get; set; }
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
