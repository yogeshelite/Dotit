using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrwrkCmp
    {
        public string Company { get; set; }
        public string WorkCompCode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public string RateQualifier { get; set; }
        public bool IncludePremiums { get; set; }
        public decimal WageLimit { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
