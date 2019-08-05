using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class KeyBlock
    {
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
