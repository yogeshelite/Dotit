using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imudcodes
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CodeTypeId { get; set; }
        public string CodeId { get; set; }
        public bool IsActive { get; set; }
        public string CodeDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool GlobalUdcodes { get; set; }
        public bool GlobalLock { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
