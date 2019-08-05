using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SolutionHeader
    {
        public SolutionHeader()
        {
            SolutionDetail = new HashSet<SolutionDetail>();
        }

        public string SolutionId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string AppVersion { get; set; }
        public string InternalNotes { get; set; }
        public string Notes { get; set; }
        public DateTime? LastExported { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string SolutionTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int BuildIteration { get; set; }
        public string SolutionReference { get; set; }

        public virtual SolutionType SolutionType { get; set; }
        public virtual ICollection<SolutionDetail> SolutionDetail { get; set; }
    }
}
