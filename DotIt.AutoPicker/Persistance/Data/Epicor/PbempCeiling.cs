using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PbempCeiling
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string EmpId { get; set; }
        public decimal Ceiling { get; set; }
        public decimal DocCeiling { get; set; }
        public decimal Rpt1Ceiling { get; set; }
        public decimal Rpt2Ceiling { get; set; }
        public decimal Rpt3Ceiling { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
