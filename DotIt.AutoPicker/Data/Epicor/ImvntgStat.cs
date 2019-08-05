using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImvntgStat
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Module { get; set; }
        public DateTime? RunDate { get; set; }
        public int RunTime { get; set; }
        public string DcdUserId { get; set; }
        public int ElapsedTime { get; set; }
        public string Comment { get; set; }
        public DateTime? CutOffDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
