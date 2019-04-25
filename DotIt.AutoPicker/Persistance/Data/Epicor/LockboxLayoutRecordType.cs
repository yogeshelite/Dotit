using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LockboxLayoutRecordType
    {
        public LockboxLayoutRecordType()
        {
            LockboxLayoutFld = new HashSet<LockboxLayoutFld>();
        }

        public string Company { get; set; }
        public string RecordTypeId { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<LockboxLayoutFld> LockboxLayoutFld { get; set; }
    }
}
