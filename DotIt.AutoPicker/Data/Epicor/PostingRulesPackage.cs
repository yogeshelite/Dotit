using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PostingRulesPackage
    {
        public PostingRulesPackage()
        {
            PostingRulesPackageSegment = new HashSet<PostingRulesPackageSegment>();
        }

        public string Package { get; set; }
        public string PackageName { get; set; }
        public bool CanBeDefault { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ICollection<PostingRulesPackageSegment> PostingRulesPackageSegment { get; set; }
    }
}
