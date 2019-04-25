using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PostingRulesPackageSegment
    {
        public PostingRulesPackageSegment()
        {
            GlbookPackageSegmentMap = new HashSet<GlbookPackageSegmentMap>();
        }

        public string Package { get; set; }
        public int SegmentNbr { get; set; }
        public string SegmentName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual PostingRulesPackage PackageNavigation { get; set; }
        public virtual ICollection<GlbookPackageSegmentMap> GlbookPackageSegmentMap { get; set; }
    }
}
