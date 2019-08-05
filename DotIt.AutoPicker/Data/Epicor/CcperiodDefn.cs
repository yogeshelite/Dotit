using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CcperiodDefn
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public int PeriodYear { get; set; }
        public int PeriodSeq { get; set; }
        public string PeriodDesc { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
