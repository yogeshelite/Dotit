using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ContextType
    {
        public ContextType()
        {
            ContextMenu = new HashSet<ContextMenu>();
        }

        public string ContextTypeCode { get; set; }
        public string CustomLayerId { get; set; }
        public string SystemCode { get; set; }
        public string Company { get; set; }
        public string UserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual CustomLayer CustomLayer { get; set; }
        public virtual Zsystem SystemCodeNavigation { get; set; }
        public virtual SysUserFile User { get; set; }
        public virtual ICollection<ContextMenu> ContextMenu { get; set; }
    }
}
