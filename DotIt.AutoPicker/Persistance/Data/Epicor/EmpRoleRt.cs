using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EmpRoleRt
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string RoleCd { get; set; }
        public DateTime? RateEffDte { get; set; }
        public string CurrencyCode { get; set; }
        public string TimeTypCd { get; set; }
        public decimal Rate { get; set; }
        public DateTime? RateEndDte { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
