using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TermsDtl
    {
        public string Company { get; set; }
        public string TermsCode { get; set; }
        public int TermsSeq { get; set; }
        public int DueOnDay { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal NumberOfMonths { get; set; }
        public decimal NumberOfDays { get; set; }
        public int MinimumDays { get; set; }
        public bool GlobalTermsDtl { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
