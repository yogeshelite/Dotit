using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LockboxLayoutFld
    {
        public LockboxLayoutFld()
        {
            LockboxLayoutDtl = new HashSet<LockboxLayoutDtl>();
        }

        public string Company { get; set; }
        public string RecordTypeId { get; set; }
        public string FieldId { get; set; }
        public string FieldName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LockboxLayoutRecordType LockboxLayoutRecordType { get; set; }
        public virtual ICollection<LockboxLayoutDtl> LockboxLayoutDtl { get; set; }
    }
}
