using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShellLayoutPersonal
    {
        public string TenantId { get; set; }
        public string LayoutId { get; set; }
        public string UserId { get; set; }
        public string BaseTenantId { get; set; }
        public string BaseLayoutId { get; set; }
        public DateTime DateModified { get; set; }
        public string ShellHomePage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string HomePageType { get; set; }
        public string SubType { get; set; }
        public string LayoutDescription { get; set; }
        public bool LastSelectedLayout { get; set; }
        public string BaseHomePageType { get; set; }
        public string BaseSubType { get; set; }

        public virtual ShellLayout Base { get; set; }
        public virtual SysUserFile User { get; set; }
    }
}
