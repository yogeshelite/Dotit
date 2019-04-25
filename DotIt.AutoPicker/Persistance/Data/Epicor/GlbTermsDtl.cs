using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTermsDtl
    {
        public string Company { get; set; }
        public decimal DiscountPercent { get; set; }
        public int DueOnDay { get; set; }
        public int MinimumDays { get; set; }
        public decimal NumberOfDays { get; set; }
        public decimal NumberOfMonths { get; set; }
        public string TermsCode { get; set; }
        public int TermsSeq { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTermsCode { get; set; }
        public int GlbTermsSeq { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTermsDtl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
