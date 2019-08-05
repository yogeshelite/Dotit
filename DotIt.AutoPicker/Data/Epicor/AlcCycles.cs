using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcCycles
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int CycleUid { get; set; }
        public string BookId { get; set; }
        public string CycleDesc { get; set; }
        public decimal ThresholdAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
