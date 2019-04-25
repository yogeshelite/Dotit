using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imterms
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TermsCode { get; set; }
        public bool SysDefault { get; set; }
        public string TermsType { get; set; }
        public string Description { get; set; }
        public int NumberOfPayments { get; set; }
        public int NumberOfDays { get; set; }
        public int MinimumDays { get; set; }
        public int DueOnDay { get; set; }
        public int NumberOfMonths { get; set; }
        public string DiscountType { get; set; }
        public bool PartPayment { get; set; }
        public bool ReqLoc { get; set; }
        public bool GlobalTerms { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Coifrscalculation { get; set; }
        public int CoifrsnumberOfPeriods { get; set; }
    }
}
