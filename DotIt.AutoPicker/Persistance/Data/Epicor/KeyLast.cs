using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class KeyLast
    {
        public string Company { get; set; }
        public string RelatedToFile { get; set; }
        public string KeyFieldName { get; set; }
        public string BlockSystemId { get; set; }
        public string BlockDeviceId { get; set; }
        public int BlockSeqNum { get; set; }
        public int BlockLastValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
