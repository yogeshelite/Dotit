using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendPbrk
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public string Pum { get; set; }
        public int VendorNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal BreakQty { get; set; }
        public decimal PriceModifier { get; set; }
        public decimal DaysOut { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
