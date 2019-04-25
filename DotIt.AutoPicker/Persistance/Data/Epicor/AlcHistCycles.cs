using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcHistCycles
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int RunNbr { get; set; }
        public int CycleUid { get; set; }
        public int CycleNumber { get; set; }
        public string CycleDesc { get; set; }
        public decimal ThresholdAmt { get; set; }
        public decimal CycleBalance { get; set; }
        public string BookId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
