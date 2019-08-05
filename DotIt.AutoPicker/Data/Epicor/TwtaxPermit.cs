using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TwtaxPermit
    {
        public string Company { get; set; }
        public DateTime EntryDate { get; set; }
        public string MainTaxOffice { get; set; }
        public string SubTaxOffice { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string ApprovalNumber { get; set; }
        public string DocumentNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
