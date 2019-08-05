using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OpMasRestriction
    {
        public string Company { get; set; }
        public string OpCode { get; set; }
        public string RestrictionTypeId { get; set; }
        public bool Manual { get; set; }
        public string Compliance { get; set; }
        public DateTime? ComplianceDate { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
