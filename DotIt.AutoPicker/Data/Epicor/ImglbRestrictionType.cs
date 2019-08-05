using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbRestrictionType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool CheckJob { get; set; }
        public bool CheckPurchase { get; set; }
        public bool CheckRfq { get; set; }
        public bool CheckSoquote { get; set; }
        public string Company { get; set; }
        public bool Compliance { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string RestrictionTypeId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRestrictionTypeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRestrictionType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
