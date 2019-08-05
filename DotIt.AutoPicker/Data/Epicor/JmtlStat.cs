using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JmtlStat
    {
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public DateTime? ReqDate { get; set; }
        public decimal RequiredQty { get; set; }
        public decimal OutstandingQty { get; set; }
        public decimal OnHandQty { get; set; }
        public decimal Wipqty { get; set; }
        public decimal AvailableQty { get; set; }
        public string Source { get; set; }
        public int Ponum { get; set; }
        public DateTime? DueDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
