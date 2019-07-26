using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AccessScope
    {
        public AccessScope()
        {
            AccessScopeEntity = new HashSet<AccessScopeEntity>();
        }

        public string Company { get; set; }
        public string AccessScopeId { get; set; }
        public string Description { get; set; }
        public bool AllowExemptBo { get; set; }
        public bool IsActive { get; set; }
        public int CompanyVisibility { get; set; }
        public bool SystemFlag { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<AccessScopeEntity> AccessScopeEntity { get; set; }
    }
}
