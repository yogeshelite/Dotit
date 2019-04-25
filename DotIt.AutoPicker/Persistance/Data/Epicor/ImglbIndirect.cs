using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbIndirect
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string ExpenseCode { get; set; }
        public string IndirectCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbIndirectCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalIndirect { get; set; }
        public bool GlobalLock { get; set; }
        public bool DownTime { get; set; }
        public bool ExternalMes { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
