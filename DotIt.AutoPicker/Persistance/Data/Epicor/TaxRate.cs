using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxRate
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public int RateType { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DeductPercent { get; set; }
        public string CurrencyCode { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public string CentCode { get; set; }
        public string CompMethod { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal PeminInvAmt { get; set; }
        public decimal PeminPayAmt { get; set; }
        public bool PeincTaxAmt { get; set; }
        public string PewhcurrencyCode { get; set; }
    }
}
