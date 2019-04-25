using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacPlanOperSched
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int PlanNum { get; set; }
        public int SchedId { get; set; }
        public DateTime? LastSchedDate { get; set; }
        public bool Range { get; set; }
        public decimal ProdStandard { get; set; }
        public decimal StartHour { get; set; }
        public decimal EndHour { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SchedType { get; set; }
        public bool Mondays { get; set; }
        public bool Tuesdays { get; set; }
        public bool Wednesdays { get; set; }
        public bool Thursdays { get; set; }
        public bool Fridays { get; set; }
        public bool Saturdays { get; set; }
        public bool Sundays { get; set; }
        public int EveryNweeks { get; set; }
        public int DayofWeek { get; set; }
        public string MonthlyOption { get; set; }
        public int DayOfMonth { get; set; }
        public string WeekOfMonth { get; set; }
        public string Otscontact { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string OtsphoneNum { get; set; }
        public string OtsfaxNum { get; set; }
        public string OtsresaleId { get; set; }
        public int OtscountryNum { get; set; }
        public string OtstaxRegionCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
