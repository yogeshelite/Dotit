using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImextPrprocGrp
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
        public string Status { get; set; }
        public DateTime? Pedate { get; set; }
        public bool PayWeekly { get; set; }
        public bool PayBiWeekly { get; set; }
        public bool PaySemiMonthly { get; set; }
        public bool PayMonthly { get; set; }
        public string CreatedBy { get; set; }
        public string PayClasses { get; set; }
        public bool SentToFile { get; set; }
        public string FilePath { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
