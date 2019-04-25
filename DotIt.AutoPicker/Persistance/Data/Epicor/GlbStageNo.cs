using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbStageNo
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string StageNumber { get; set; }
        public string GlbCompany { get; set; }
        public string GlbStageNumber { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalStageNo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
