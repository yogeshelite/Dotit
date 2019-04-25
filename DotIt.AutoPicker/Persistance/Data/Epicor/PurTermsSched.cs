using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PurTermsSched
    {
        public string Company { get; set; }
        public string TermsCode { get; set; }
        public int PaySeq { get; set; }
        public int Days { get; set; }
        public decimal PayPercent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PurTerms PurTerms { get; set; }
    }
}
