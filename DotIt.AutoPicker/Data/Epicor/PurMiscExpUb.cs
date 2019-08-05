using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PurMiscExpUb
    {
        public string Company { get; set; }
        public string MiscCode { get; set; }
        public DateTime? FromEffectiveDate { get; set; }
        public DateTime? ToEffectiveDate { get; set; }
        public string ExpenseUnitDesc { get; set; }
        public bool Inactive { get; set; }
        public decimal ClaimUnitMaximum { get; set; }
        public decimal ClaimUnitAmount { get; set; }
        public bool Override { get; set; }
        public string ClaimCurrencyCode { get; set; }
        public bool GlobalPurMiscExpUb { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
