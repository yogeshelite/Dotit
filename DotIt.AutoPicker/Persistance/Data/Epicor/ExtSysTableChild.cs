using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtSysTableChild
    {
        public string ExtSystemId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ChildSchemaName { get; set; }
        public string ChildTableName { get; set; }
        public bool SystemFlag { get; set; }
        public string InOutNeitherBoth { get; set; }
        public string FilterColumnName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtSysTable ExtSysTable { get; set; }
    }
}
