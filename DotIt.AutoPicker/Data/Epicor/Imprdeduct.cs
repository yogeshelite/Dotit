using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imprdeduct
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
