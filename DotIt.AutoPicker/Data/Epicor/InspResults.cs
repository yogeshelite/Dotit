using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class InspResults
    {
        public string Company { get; set; }
        public string InspPlanType { get; set; }
        public string File { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public int SampleNumber { get; set; }
        public DateTime? InspectDate { get; set; }
        public int InspectTime { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int NcmtranId { get; set; }
        public string InspPlanPartNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public int VendorNum { get; set; }
        public string SerialNum { get; set; }
        public string LotNum { get; set; }
        public bool Passed { get; set; }
        public string FailedCmtText { get; set; }
        public bool TestDataEntered { get; set; }
        public int AuditRefNum { get; set; }
        public string PurPoint { get; set; }
        public string AuditType { get; set; }
        public string AuditId { get; set; }
        public string AuditRevNum { get; set; }
        public string Auditor { get; set; }
        public DateTime? AuditSchedDate { get; set; }
        public DateTime? AuditCreateDate { get; set; }
        public string EmpId { get; set; }
        public int AuditVendNum { get; set; }
        public DateTime? AuditCompDate { get; set; }
        public string AuditStatus { get; set; }
        public string AuditResult { get; set; }
        public int AuditConNum { get; set; }
        public string AuditConRole { get; set; }
        public decimal AuditCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
