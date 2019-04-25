using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbUom
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
        public string Company { get; set; }
        public int NumOfDec { get; set; }
        public string Rounding { get; set; }
        public string Uomcode { get; set; }
        public string Uomdesc { get; set; }
        public string Uomsymbol { get; set; }
        public string GlbCompany { get; set; }
        public string GlbUomcode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agafipcode { get; set; }
        public string Agcotcode { get; set; }
        public string Pesunatcode { get; set; }
        public string MxcustomsUom { get; set; }
        public string Mxsatcode { get; set; }
    }
}
