using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPurMiscExpUb
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string ClaimCurrencyCode { get; set; }
        public decimal ClaimUnitAmount { get; set; }
        public decimal ClaimUnitMaximum { get; set; }
        public string Company { get; set; }
        public string ExpenseUnitDesc { get; set; }
        public DateTime? FromEffectiveDate { get; set; }
        public bool Inactive { get; set; }
        public string MiscCode { get; set; }
        public bool Override { get; set; }
        public DateTime? ToEffectiveDate { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMiscCode { get; set; }
        public DateTime? GlbFromEffectiveDate { get; set; }
        public string GlbClaimCurrencyCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPurMiscExpUb { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
