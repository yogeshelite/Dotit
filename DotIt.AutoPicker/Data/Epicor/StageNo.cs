using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class StageNo
    {
        public string Company { get; set; }
        public string StageNumber { get; set; }
        public string Description { get; set; }
        public bool GlobalStageNo { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
