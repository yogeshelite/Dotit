using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxGrate
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public decimal FromAmount { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal TaxAmount { get; set; }
        public bool ReverseCharge { get; set; }
        public string TextCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
