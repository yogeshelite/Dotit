using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImaccountLockoutPolicy
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string TenantId { get; set; }
        public int? LockoutDuration { get; set; }
        public int LockoutThreshold { get; set; }
        public int? ResetAccountLockoutCounterAfter { get; set; }
        public bool IncrementalLockoutDuration { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
