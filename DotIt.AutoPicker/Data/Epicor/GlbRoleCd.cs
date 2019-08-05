using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbRoleCd
    {
        public int ApprovalSupervisorLevel { get; set; }
        public bool Commissionable { get; set; }
        public string Company { get; set; }
        public bool EmployeeRole { get; set; }
        public bool ExpenseApprover { get; set; }
        public bool Inactive { get; set; }
        public bool ProjectMgrRole { get; set; }
        public string ResourceGrpId { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }
        public bool SupervisorRole { get; set; }
        public bool TimeApprover { get; set; }
        public bool UseResGrp { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRoleCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRoleCd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
