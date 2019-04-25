using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Counter
    {
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
