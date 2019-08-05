using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcBatchCd
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public string AllocId { get; set; }
        public int Tier { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
