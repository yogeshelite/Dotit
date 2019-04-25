using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AuditSched
    {
        public string Company { get; set; }
        public int AuditRefNum { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string AuditType { get; set; }
        public string AuditId { get; set; }
        public string RevisionNum { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string InspPlanNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string Auditor { get; set; }
        public string AudStatus { get; set; }
        public DateTime? DateCreated { get; set; }
        public string EmpId { get; set; }
        public string RoleCode { get; set; }
        public int AuditVendNum { get; set; }
        public int AuditConNum { get; set; }
        public string AuditConRole { get; set; }
        public DateTime? SchedDate { get; set; }
        public decimal EstUnitCost { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
