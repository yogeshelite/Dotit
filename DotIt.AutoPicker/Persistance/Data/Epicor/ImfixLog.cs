using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfixLog
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
