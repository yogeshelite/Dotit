using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtableAttribute
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public bool AutoImwriteTrigger { get; set; }
        public bool AutoImdeleteTrigger { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
