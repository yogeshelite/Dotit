using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysAgentSched
    {
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public string SchedDesc { get; set; }
        public string SchedType { get; set; }
        public DateTime? NextRunOn { get; set; }
        public int Recurrences { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string MonthlyOption { get; set; }
        public int DayOfMonth { get; set; }
        public string WeekOfMonth { get; set; }
        public int DayOfWeek { get; set; }
        public int EveryNweeks { get; set; }
        public DateTime? LastRunOn { get; set; }
        public bool Mondays { get; set; }
        public bool Tuesdays { get; set; }
        public bool Wednesdays { get; set; }
        public bool Thursdays { get; set; }
        public bool Fridays { get; set; }
        public bool Saturdays { get; set; }
        public bool Sundays { get; set; }
        public bool Enabled { get; set; }
        public string AppSrvConnectionId { get; set; }
        public int IntervalTime { get; set; }
        public string SecCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? ProcessingStartedOn { get; set; }
    }
}
