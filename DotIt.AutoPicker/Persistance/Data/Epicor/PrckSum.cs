using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrckSum
    {
        public string Company { get; set; }
        public string EmpLink { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public int DeductionNum { get; set; }
        public decimal Hours { get; set; }
        public decimal TdbaseAmt { get; set; }
        public decimal TdpremiumAmt { get; set; }
        public decimal MtddedAmt { get; set; }
        public decimal Tdtaxable { get; set; }
        public decimal TdshiftAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
