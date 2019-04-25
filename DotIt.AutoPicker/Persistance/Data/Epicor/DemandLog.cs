using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DemandLog
    {
        public string Company { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int DemandScheduleSeq { get; set; }
        public int TranNum { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string LogText { get; set; }
        public string Action { get; set; }
        public string LogCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ScheduleNumber { get; set; }
    }
}
