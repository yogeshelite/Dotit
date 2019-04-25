using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglrecSched
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int RecurNum { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string BookId { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? ReversalApplyDate { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string SchedStatus { get; set; }
        public string ProcStatus { get; set; }
        public string FailureReason { get; set; }
        public int CloseFiscalPeriod { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
