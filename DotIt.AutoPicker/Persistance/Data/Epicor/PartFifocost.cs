using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartFifocost
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public string CostId { get; set; }
        public DateTime? Fifodate { get; set; }
        public int Fifoseq { get; set; }
        public int FifosubSeq { get; set; }
        public bool InActive { get; set; }
        public decimal OnHandQty { get; set; }
        public decimal FifolaborCost { get; set; }
        public decimal FifoburdenCost { get; set; }
        public decimal FifomaterialCost { get; set; }
        public decimal FifosubContCost { get; set; }
        public decimal FifomtlBurCost { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string SourceType { get; set; }
        public DateTime? SourceSysDate { get; set; }
        public int SourceSysTime { get; set; }
        public int SourceTranNum { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public decimal OrigOnHandQty { get; set; }
        public decimal ConsumedQty { get; set; }
        public DateTime? LastRefDate { get; set; }
        public string SourceTable { get; set; }
        public string SourceKey1 { get; set; }
        public string SourceKey2 { get; set; }
        public string SourceKey3 { get; set; }
        public string SourceKey4 { get; set; }
        public string SourceKey5 { get; set; }
        public string SourceKey6 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
