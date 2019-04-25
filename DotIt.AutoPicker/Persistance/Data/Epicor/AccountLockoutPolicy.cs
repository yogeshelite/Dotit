using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AccountLockoutPolicy
    {
        public string TenantId { get; set; }
        public int? LockoutDuration { get; set; }
        public int LockoutThreshold { get; set; }
        public int? ResetAccountLockoutCounterAfter { get; set; }
        public bool IncrementalLockoutDuration { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
