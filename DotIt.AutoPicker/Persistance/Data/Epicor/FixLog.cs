using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FixLog
    {
        public string Company { get; set; }
        public int Sequence { get; set; }
        public string FixName { get; set; }
        public DateTime? ExecDate { get; set; }
        public string LogName { get; set; }
        public int AffectedRows { get; set; }
        public string ExecBy { get; set; }
        public string Comment { get; set; }
        public int Dblevel { get; set; }
        public string DbpatchLevel { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
