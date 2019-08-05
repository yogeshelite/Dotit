using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImroughCutParam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
