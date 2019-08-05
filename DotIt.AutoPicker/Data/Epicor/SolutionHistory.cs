using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SolutionHistory
    {
        public string Company { get; set; }
        public string SolutionId { get; set; }
        public long Sequence { get; set; }
        public string Event { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int BuildIteration { get; set; }
        public string SolutionReference { get; set; }
    }
}
