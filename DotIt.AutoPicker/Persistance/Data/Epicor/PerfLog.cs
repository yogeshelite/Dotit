using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PerfLog
    {
        public string Company { get; set; }
        public DateTime? DateStamp { get; set; }
        public int TimeStamp { get; set; }
        public string DcdUserId { get; set; }
        public string LogText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
