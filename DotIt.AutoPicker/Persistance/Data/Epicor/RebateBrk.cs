using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RebateBrk
    {
        public string Company { get; set; }
        public string RebateId { get; set; }
        public int LineNum { get; set; }
        public decimal BreakMin { get; set; }
        public decimal RebatePercent { get; set; }
        public decimal RebateAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
