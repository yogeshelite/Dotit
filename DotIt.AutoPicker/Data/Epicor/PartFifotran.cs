using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartFifotran
    {
        public string Company { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int TranNum { get; set; }
        public int TranSeq { get; set; }
        public string TranType { get; set; }
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public string CostId { get; set; }
        public DateTime? Fifodate { get; set; }
        public int Fifoseq { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal TranQty { get; set; }
        public string Um { get; set; }
        public decimal MtlUnitCost { get; set; }
        public decimal LbrUnitCost { get; set; }
        public decimal BurUnitCost { get; set; }
        public decimal SubUnitCost { get; set; }
        public decimal MtlBurUnitCost { get; set; }
        public decimal ExtCost { get; set; }
        public string Fifoaction { get; set; }
        public int FifosubSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal IssueReturnQty { get; set; }
        public int Dmrnum { get; set; }
        public int NonConfId { get; set; }
        public decimal ConsumedQty { get; set; }
        public DateTime? SourceSysDate { get; set; }
        public int SourceSysTime { get; set; }
        public int SourceTranNum { get; set; }
        public int SourceTranSeq { get; set; }
        public bool SourceConsumed { get; set; }
    }
}
