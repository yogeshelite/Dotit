using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EccudmapColumn
    {
        public string Company { get; set; }
        public string MapId { get; set; }
        public string MessageType { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnLabel { get; set; }
        public bool Enabled { get; set; }
        public bool Custom { get; set; }
        public bool Attribute { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual EccudmapTable EccudmapTable { get; set; }
    }
}
