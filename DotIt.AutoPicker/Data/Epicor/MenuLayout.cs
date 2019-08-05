using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MenuLayout
    {
        public MenuLayout()
        {
            MenuAccess = new HashSet<MenuAccess>();
        }

        public string Company { get; set; }
        public string MenuLayoutId { get; set; }
        public string MenuProcessId { get; set; }
        public string MenuNodeType { get; set; }
        public string ParentMenuId { get; set; }
        public string SystemCode { get; set; }
        public bool Delivered { get; set; }
        public int MenuSequence { get; set; }
        public int UdmenuSequence { get; set; }
        public bool Visible { get; set; }
        public bool Udvisible { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual MenuProcess MenuProcess { get; set; }
        public virtual ICollection<MenuAccess> MenuAccess { get; set; }
    }
}
