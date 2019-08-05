using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcounter
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CounterId { get; set; }
        public int OpSecNum { get; set; }
        public int OpAppSeqNum { get; set; }
        public int IpSecNum { get; set; }
        public int IpAppSeqNum { get; set; }
        public string GroupId { get; set; }
        public DateTime? ReserveDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
