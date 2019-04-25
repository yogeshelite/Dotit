using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IncomeTaxRate
    {
        public string Company { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal Rate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
