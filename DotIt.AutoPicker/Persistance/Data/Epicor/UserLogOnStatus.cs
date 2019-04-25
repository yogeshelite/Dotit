using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class UserLogOnStatus
    {
        public string UserId { get; set; }
        public DateTime? LockedOutOn { get; set; }
        public DateTime? LastLogOnFailedOn { get; set; }
        public int FailedAttempts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
