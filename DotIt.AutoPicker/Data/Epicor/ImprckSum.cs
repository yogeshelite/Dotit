using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImprckSum
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
