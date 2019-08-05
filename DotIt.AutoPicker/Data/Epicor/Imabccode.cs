using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imabccode
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Abccode { get; set; }
        public int CountFreq { get; set; }
        public bool ExcludeFromCc { get; set; }
        public decimal StockValPcnt { get; set; }
        public decimal PcntTolerance { get; set; }
        public bool CalcPcnt { get; set; }
        public bool CalcQty { get; set; }
        public bool CalcValue { get; set; }
        public decimal QtyTolerance { get; set; }
        public decimal ValueTolerance { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
