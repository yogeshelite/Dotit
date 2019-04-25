using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LockboxLayoutDtl
    {
        public string Company { get; set; }
        public string LayoutId { get; set; }
        public string RecordTypeId { get; set; }
        public string FieldId { get; set; }
        public int Offset { get; set; }
        public int Length { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LockboxLayoutFld LockboxLayoutFld { get; set; }
        public virtual LockboxLayoutHead LockboxLayoutHead { get; set; }
    }
}
