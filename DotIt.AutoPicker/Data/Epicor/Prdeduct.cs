using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Prdeduct
    {
        public string Company { get; set; }
        public string DeductionId { get; set; }
        public string Description { get; set; }
        public string SpecialType { get; set; }
        public int Priority { get; set; }
        public string RateQualifier { get; set; }
        public bool DecliningBal { get; set; }
        public bool CarryOver { get; set; }
        public string ExemptTaxes { get; set; }
        public bool ElecDeposit { get; set; }
        public bool Hcmlinked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeNetEarnings { get; set; }
        public bool IncludeEmployeeGrossIncome { get; set; }
    }
}
