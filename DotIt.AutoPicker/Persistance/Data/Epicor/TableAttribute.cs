using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TableAttribute
    {
        public TableAttribute()
        {
            ColumnAttribute = new HashSet<ColumnAttribute>();
        }

        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public bool AutoImwriteTrigger { get; set; }
        public bool AutoImdeleteTrigger { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? LastUpdated { get; set; }

        public virtual ICollection<ColumnAttribute> ColumnAttribute { get; set; }
    }
}
