using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaskSnxt
    {
        public string Company { get; set; }
        public string TaskSetId { get; set; }
        public int TaskSetSeq { get; set; }
        public int NextTaskSeq { get; set; }
        public bool DefaultNext { get; set; }
        public bool DefaultNextForReject { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
