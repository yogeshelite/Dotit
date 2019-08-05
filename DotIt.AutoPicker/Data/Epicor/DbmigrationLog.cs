using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DbmigrationLog
    {
        public int LogId { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Dbaction { get; set; }
        public string Dbresult { get; set; }
        public string DbtaskXml { get; set; }
        public string Dblog { get; set; }
        public string IcefromSystemVersion { get; set; }
        public string AppFromSystemVersion { get; set; }
        public string IcetoSystemVersion { get; set; }
        public string AppToSystemVersion { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
