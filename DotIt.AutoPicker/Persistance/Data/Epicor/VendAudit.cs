using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VendAudit
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string AuditId { get; set; }
        public string RevisionNum { get; set; }
        public bool InActive { get; set; }
        public string Auditor { get; set; }
        public string EmpId { get; set; }
        public string RoleCode { get; set; }
        public int AuditVendNum { get; set; }
        public int AuditConNum { get; set; }
        public string AuditConRole { get; set; }
        public int AuditFreq { get; set; }
        public DateTime? LastAuditDate { get; set; }
        public bool Passed { get; set; }
        public int LastAuditRefNum { get; set; }
        public DateTime? NextAuditDate { get; set; }
        public bool AuditScheduled { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
