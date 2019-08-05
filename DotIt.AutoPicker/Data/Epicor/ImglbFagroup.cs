using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbFagroup
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool AdditionSpread { get; set; }
        public string AssetMethod { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool Finalspread { get; set; }
        public string GroupCode { get; set; }
        public string JournalCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbGroupCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFagroup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
