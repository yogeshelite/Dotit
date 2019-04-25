using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartRestriction
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RestrictionTypeId { get; set; }
        public bool Manual { get; set; }
        public string RollupType { get; set; }
        public string Compliance { get; set; }
        public DateTime? ComplianceDate { get; set; }
        public DateTime? LastRollUp { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
