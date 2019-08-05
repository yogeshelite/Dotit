using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AccessScopeEntity
    {
        public AccessScopeEntity()
        {
            AccessScopeBomethod = new HashSet<AccessScopeBomethod>();
        }

        public string Company { get; set; }
        public string AccessScopeId { get; set; }
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public string EntityDescription { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual AccessScope AccessScope { get; set; }
        public virtual ICollection<AccessScopeBomethod> AccessScopeBomethod { get; set; }
    }
}
