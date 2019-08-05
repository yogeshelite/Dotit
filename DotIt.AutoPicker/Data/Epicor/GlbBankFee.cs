using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbBankFee
    {
        public string BankFeeId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string IncomeTaxCode { get; set; }
        public string RateCode { get; set; }
        public string TaxCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbBankFeeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalBankFee { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
