using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPrjRoleRt
    {
        public string Company { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public DateTime? RateEffDte { get; set; }
        public DateTime? RateEndDte { get; set; }
        public string RoleCd { get; set; }
        public int Seq { get; set; }
        public string TimeTypCd { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRoleCd { get; set; }
        public int GlbSeq { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPrjRoleRt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
