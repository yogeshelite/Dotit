using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Uom
    {
        public string Company { get; set; }
        public string Uomcode { get; set; }
        public string Uomdesc { get; set; }
        public bool Active { get; set; }
        public string Uomsymbol { get; set; }
        public bool AllowDecimals { get; set; }
        public int NumOfDec { get; set; }
        public string Rounding { get; set; }
        public bool GlobalUom { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agafipcode { get; set; }
        public string Agcotcode { get; set; }
        public string Pesunatcode { get; set; }
        public string MxcustomsUom { get; set; }
        public string Mxsatcode { get; set; }
        public string PecommercialUom { get; set; }
    }
}
