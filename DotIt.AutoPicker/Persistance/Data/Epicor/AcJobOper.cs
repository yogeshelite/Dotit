using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcJobOper
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string TaskSetId { get; set; }
        public string LastTaskId { get; set; }
        public string ActiveTaskId { get; set; }
        public string CurrentMilestone { get; set; }
        public int CurrentWfstageId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
