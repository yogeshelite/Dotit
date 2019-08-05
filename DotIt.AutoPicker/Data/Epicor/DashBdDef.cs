using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DashBdDef
    {
        public string Company { get; set; }
        public string ProductId { get; set; }
        public string GlbCompany { get; set; }
        public string DefinitionId { get; set; }
        public string Description { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DashBdVersion { get; set; }
        public int DataBaseVersion { get; set; }
        public bool Delivered { get; set; }
        public bool MobileAccess { get; set; }
        public string Cgccode { get; set; }
        public DateTime? LastDeployedDate { get; set; }
        public string LastDeployedBy { get; set; }
        public string DashboardSchema { get; set; }
        public string DashboardAssembly { get; set; }
        public bool WebAccess { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Caption { get; set; }
        public int CompanyVisibility { get; set; }
        public bool? HasDashboardAssembly { get; set; }
    }
}
