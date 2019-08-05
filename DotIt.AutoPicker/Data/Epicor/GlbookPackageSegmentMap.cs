using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbookPackageSegmentMap
    {
        public string Company { get; set; }
        public string BookId { get; set; }
        public string Package { get; set; }
        public int SourceSegmentNbr { get; set; }
        public int TargetSegmentNbr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PostingRulesPackageSegment PostingRulesPackageSegment { get; set; }
    }
}
