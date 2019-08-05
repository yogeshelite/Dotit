using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysUserComp
    {
        public SysUserComp()
        {
            SysUserCompExt = new HashSet<SysUserCompExt>();
        }

        public string UserId { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string CurPlant { get; set; }
        public string PlantList { get; set; }
        public string SolutionId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysCompany CompanyNavigation { get; set; }
        public virtual SysUserFile User { get; set; }
        public virtual ICollection<SysUserCompExt> SysUserCompExt { get; set; }
    }
}
