using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendPartRestriction
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public string Pum { get; set; }
        public int VendorNum { get; set; }
        public string RestrictionTypeId { get; set; }
        public bool Manual { get; set; }
        public bool RollUp { get; set; }
        public string Compliance { get; set; }
        public DateTime? ComplianceDate { get; set; }
        public DateTime? LastRollUp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
