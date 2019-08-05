using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LotSeq
    {
        public string Company { get; set; }
        public string LotSeqId { get; set; }
        public int LotNxtNum { get; set; }
        public bool InActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
