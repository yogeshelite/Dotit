using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbstatUom
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string StatUomcode { get; set; }
        public string Uomdesc { get; set; }
        public bool Active { get; set; }
        public string StatUomsymbol { get; set; }
        public bool AllowDecimals { get; set; }
        public int NumOfDec { get; set; }
        public bool GlobalUom { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
