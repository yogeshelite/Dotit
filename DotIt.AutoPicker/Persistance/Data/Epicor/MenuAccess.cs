using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MenuAccess
    {
        public string Company { get; set; }
        public string MenuLayoutId { get; set; }
        public string MenuAccessId { get; set; }
        public string MenuType { get; set; }
        public bool Delivered { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual MenuLayout MenuLayout { get; set; }
    }
}
