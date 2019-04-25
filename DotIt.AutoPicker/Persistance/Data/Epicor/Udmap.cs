using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Udmap
    {
        public Udmap()
        {
            UdmapTable = new HashSet<UdmapTable>();
        }

        public int MapId { get; set; }
        public string Description { get; set; }
        public string TargetSchemaName { get; set; }
        public string TargetTableName { get; set; }
        public string SourceSchemaName { get; set; }
        public string SourceTableName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<UdmapTable> UdmapTable { get; set; }
    }
}
