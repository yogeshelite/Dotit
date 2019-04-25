using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImkeyBlock
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
        public string KeyFieldName { get; set; }
        public string BlockSystemId { get; set; }
        public string BlockDeviceId { get; set; }
        public int BlockSeqNum { get; set; }
        public int BlockStartNum { get; set; }
        public int BlockEndNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
