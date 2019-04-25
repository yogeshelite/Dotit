using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EccudmapTable
    {
        public EccudmapTable()
        {
            EccudmapColumn = new HashSet<EccudmapColumn>();
        }

        public string Company { get; set; }
        public string MapId { get; set; }
        public string MessageType { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public bool Enabled { get; set; }
        public bool UseBpm { get; set; }
        public bool HasAttribute { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<EccudmapColumn> EccudmapColumn { get; set; }
    }
}
