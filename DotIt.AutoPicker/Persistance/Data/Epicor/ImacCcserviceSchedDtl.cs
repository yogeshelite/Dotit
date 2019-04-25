using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacCcserviceSchedDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ServicePlanId { get; set; }
        public int ServicePlanDtlId { get; set; }
        public int SchedId { get; set; }
        public int SchedDtlId { get; set; }
        public bool WeeklyMonday { get; set; }
        public bool WeeklyTuesday { get; set; }
        public bool WeeklyWednesday { get; set; }
        public bool WeeklyThursday { get; set; }
        public bool WeeklyFriday { get; set; }
        public bool WeeklySaturday { get; set; }
        public bool WeeklySunday { get; set; }
        public int WeeklyDayOfWeek { get; set; }
        public string MonthlyOption { get; set; }
        public int MonthlyDayOfMonth { get; set; }
        public string MonthlyWeekOfMonth { get; set; }
        public int MonthlyDayOfWeek { get; set; }
        public int YearlyMonthofYear { get; set; }
        public int YearlyDayOfMonth { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int ServiceHours { get; set; }
        public int ServiceMinutes { get; set; }
        public decimal ServiceQty { get; set; }
        public string Remark { get; set; }
        public string OpCode { get; set; }
        public string OpDesc { get; set; }
        public string Capability { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public string AddressType { get; set; }
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
