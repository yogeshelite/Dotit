using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ChangeLog
    {
        public long ChangeLogId { get; set; }
        public string Company { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string Action { get; set; }
        public string ChangeData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Identifier { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
