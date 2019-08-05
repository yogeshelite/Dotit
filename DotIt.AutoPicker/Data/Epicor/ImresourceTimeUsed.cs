using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImresourceTimeUsed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public bool WhatIf { get; set; }
        public int AllocNum { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public DateTime? StartDate { get; set; }
        public int StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public int EndTime { get; set; }
        public bool Lock { get; set; }
        public DateTime? LoadDate { get; set; }
        public decimal LoadHour { get; set; }
        public decimal EstHours { get; set; }
        public decimal ActualHours { get; set; }
        public string LoadDays { get; set; }
        public string LoadHours { get; set; }
        public string RestoreFlag { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public bool JobEngineered { get; set; }
        public string DailyProdQty { get; set; }
        public string SysUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
