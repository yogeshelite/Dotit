using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LaborHed
    {
        public string Company { get; set; }
        public string EmployeeNum { get; set; }
        public int LaborHedSeq { get; set; }
        public DateTime? PayrollDate { get; set; }
        public int Shift { get; set; }
        public DateTime? ClockInDate { get; set; }
        public decimal ClockInTime { get; set; }
        public string DspClockInTime { get; set; }
        public decimal ActualClockInTime { get; set; }
        public DateTime? ActualClockinDate { get; set; }
        public string LunchStatus { get; set; }
        public decimal ActLunchOutTime { get; set; }
        public decimal LunchOutTime { get; set; }
        public decimal ActLunchInTime { get; set; }
        public decimal LunchInTime { get; set; }
        public decimal ClockOutTime { get; set; }
        public string DspClockOutTime { get; set; }
        public decimal ActualClockOutTime { get; set; }
        public decimal PayHours { get; set; }
        public bool FeedPayroll { get; set; }
        public bool TransferredToPayroll { get; set; }
        public bool LaborCollection { get; set; }
        public string TranSet { get; set; }
        public bool ActiveTrans { get; set; }
        public string ChkLink { get; set; }
        public string BatchTotalHrsDisp { get; set; }
        public string BatchHrsRemainDisp { get; set; }
        public string BatchHrsRemainPctDisp { get; set; }
        public string BatchSplitHrsMethod { get; set; }
        public bool BatchAssignTo { get; set; }
        public bool BatchComplete { get; set; }
        public DateTime? BatchStartHrs { get; set; }
        public DateTime? BatchEndHrs { get; set; }
        public decimal BatchTotalHrs { get; set; }
        public decimal BatchHrsRemain { get; set; }
        public decimal BatchHrsRemainPct { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Imported { get; set; }
        public DateTime? ImportDate { get; set; }
        public bool BatchMode { get; set; }
        public string HcmpayHoursCalcType { get; set; }
    }
}
