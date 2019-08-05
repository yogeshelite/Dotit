using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrvLock
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string Key6 { get; set; }
        public DateTime? LockDate { get; set; }
        public int LockTime { get; set; }
        public string LockedBy { get; set; }
        public int RvJrnUid { get; set; }
        public string LockStatus { get; set; }
        public string Abtuid { get; set; }
        public string GlbAbtuid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public long SysTaskNum { get; set; }
    }
}
