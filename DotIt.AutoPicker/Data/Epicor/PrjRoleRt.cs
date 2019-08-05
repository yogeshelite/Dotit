using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrjRoleRt
    {
        public string Company { get; set; }
        public string RoleCd { get; set; }
        public DateTime? RateEffDte { get; set; }
        public string CurrencyCode { get; set; }
        public string TimeTypCd { get; set; }
        public decimal Rate { get; set; }
        public DateTime? RateEndDte { get; set; }
        public int Seq { get; set; }
        public bool GlobalPrjRoleRt { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
