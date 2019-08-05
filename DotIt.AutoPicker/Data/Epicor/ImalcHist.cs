using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImalcHist
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BatchId { get; set; }
        public string AllocId { get; set; }
        public int RunNbr { get; set; }
        public DateTime? RunDate { get; set; }
        public int RunTime { get; set; }
        public int RunType { get; set; }
        public string DcdUserId { get; set; }
        public string BookId { get; set; }
        public bool Simulation { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? ApplyDateRev { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? SchedDate { get; set; }
        public string BatchDesc { get; set; }
        public int Tier { get; set; }
        public int SchedNum { get; set; }
        public bool Reverse { get; set; }
        public bool Ytdalloc { get; set; }
        public bool AllocReversed { get; set; }
        public string PriorTgtStamp { get; set; }
        public string TgtStamp { get; set; }
        public string SrcAllocStamp { get; set; }
        public bool IgnoreStamp { get; set; }
        public bool UseAllStamps { get; set; }
        public int AllocOption { get; set; }
        public decimal PercentToAlloc { get; set; }
        public bool UseAllocUnits { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool StatBalAsAllocUnits { get; set; }
    }
}
