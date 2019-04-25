using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtCompanyTable
    {
        public ExtCompanyTable()
        {
            ExtCompanyTableChild = new HashSet<ExtCompanyTableChild>();
        }

        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string LastSendSysRevId { get; set; }
        public DateTime? LastSendDateTime { get; set; }
        public string FilterColumnName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ExtCompanyTableChild> ExtCompanyTableChild { get; set; }
    }
}
