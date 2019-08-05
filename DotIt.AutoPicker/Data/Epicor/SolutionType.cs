using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SolutionType
    {
        public SolutionType()
        {
            SolutionHeader = new HashSet<SolutionHeader>();
            SolutionTypeDetail = new HashSet<SolutionTypeDetail>();
        }

        public string SolutionTypeId { get; set; }
        public string SolutionTypeDesc { get; set; }
        public bool IsDelivered { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<SolutionHeader> SolutionHeader { get; set; }
        public virtual ICollection<SolutionTypeDetail> SolutionTypeDetail { get; set; }
    }
}
