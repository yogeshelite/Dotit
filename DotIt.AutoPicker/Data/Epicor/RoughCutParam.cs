using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RoughCutParam
    {
        public string Company { get; set; }
        public string RoughCutCode { get; set; }
        public string Description { get; set; }
        public decimal SetupPct { get; set; }
        public decimal SetupMinChgHrs { get; set; }
        public decimal SetupMaxChgHrs { get; set; }
        public decimal FixedPct { get; set; }
        public decimal FixedMinChgHrs { get; set; }
        public decimal FixedMaxChgHrs { get; set; }
        public decimal VariablePct { get; set; }
        public decimal VarMinChgHrs { get; set; }
        public decimal VarMaxChgHrs { get; set; }
        public decimal SubCntPct { get; set; }
        public decimal SubCminChgDays { get; set; }
        public decimal SubCmaxChgDays { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
