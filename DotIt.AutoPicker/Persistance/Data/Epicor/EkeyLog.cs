using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EkeyLog
    {
        public string Company { get; set; }
        public int LogNum { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string RunStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
