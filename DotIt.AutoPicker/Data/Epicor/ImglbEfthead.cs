using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbEfthead
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
        public int EftheadUid { get; set; }
        public bool IsSystem { get; set; }
        public string Name { get; set; }
        public string Program { get; set; }
        public int Type { get; set; }
        public string GlbCompany { get; set; }
        public int GlbEftheadUid { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalEfthead { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
