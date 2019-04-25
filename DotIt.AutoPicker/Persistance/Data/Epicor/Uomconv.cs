using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Uomconv
    {
        public string Company { get; set; }
        public string UomclassId { get; set; }
        public string Uomcode { get; set; }
        public decimal ConvFactor { get; set; }
        public string Uomdesc { get; set; }
        public bool BaseUom83 { get; set; }
        public string Uomcode83 { get; set; }
        public bool Active { get; set; }
        public string Uomsymbol { get; set; }
        public bool AllowDecimals { get; set; }
        public int NumOfDec { get; set; }
        public string Rounding { get; set; }
        public bool StdUom { get; set; }
        public bool PartSpecific { get; set; }
        public bool HasBeenUsed { get; set; }
        public string ConvOperator { get; set; }
        public bool GlobalUomconv { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
