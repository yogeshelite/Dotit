using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImjobAsmblRestriction
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string RestrictionTypeId { get; set; }
        public string PartNum { get; set; }
        public bool Manual { get; set; }
        public string RollupType { get; set; }
        public string Compliance { get; set; }
        public DateTime? ComplianceDate { get; set; }
        public DateTime? LastRollUp { get; set; }
        public string BuiltCompliance { get; set; }
        public DateTime? BuiltComplianceDate { get; set; }
        public DateTime? BuiltLastRollUp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
