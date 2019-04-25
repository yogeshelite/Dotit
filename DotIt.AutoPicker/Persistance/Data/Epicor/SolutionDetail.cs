using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SolutionDetail
    {
        public string SolutionId { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string TableName { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SolutionHeader Solution { get; set; }
    }
}
