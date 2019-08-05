using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbUomconv
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool Active { get; set; }
        public bool AllowDecimals { get; set; }
        public bool BaseUom83 { get; set; }
        public string Company { get; set; }
        public decimal ConvFactor { get; set; }
        public string ConvOperator { get; set; }
        public bool HasBeenUsed { get; set; }
        public int NumOfDec { get; set; }
        public bool PartSpecific { get; set; }
        public string Rounding { get; set; }
        public bool StdUom { get; set; }
        public string UomclassId { get; set; }
        public string Uomcode { get; set; }
        public string Uomcode83 { get; set; }
        public string Uomdesc { get; set; }
        public string Uomsymbol { get; set; }
        public string GlbCompany { get; set; }
        public string GlbUomclassId { get; set; }
        public string GlbUomcode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalUomconv { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
