using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CashFlowEstimate
    {
        public string Company { get; set; }
        public int CashFlowSeq { get; set; }
        public string Direction { get; set; }
        public decimal EstimateAmt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal AveragePerDay { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
