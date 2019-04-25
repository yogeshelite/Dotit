using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ContextMenu
    {
        public ContextMenu()
        {
            ContextMenuItem = new HashSet<ContextMenuItem>();
            ContextValidation = new HashSet<ContextValidation>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ContextType ContextTypeCodeNavigation { get; set; }
        public virtual ICollection<ContextMenuItem> ContextMenuItem { get; set; }
        public virtual ICollection<ContextValidation> ContextValidation { get; set; }
    }
}
