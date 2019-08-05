using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTerms
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string DiscountType { get; set; }
        public int DueOnDay { get; set; }
        public int MinimumDays { get; set; }
        public int NumberOfDays { get; set; }
        public int NumberOfMonths { get; set; }
        public int NumberOfPayments { get; set; }
        public bool PartPayment { get; set; }
        public bool ReqLoc { get; set; }
        public bool SysDefault { get; set; }
        public string TermsCode { get; set; }
        public string TermsType { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTermsCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTerms { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
