using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImextPrgrpEmp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string EmpId { get; set; }
        public DateTime? Psdate { get; set; }
        public DateTime? Pedate { get; set; }
        public decimal TotalBaseHours { get; set; }
        public decimal TotalOthours { get; set; }
        public decimal TotalDthours { get; set; }
        public string PayClassId { get; set; }
        public string PayFreq { get; set; }
        public bool SentToFile { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
