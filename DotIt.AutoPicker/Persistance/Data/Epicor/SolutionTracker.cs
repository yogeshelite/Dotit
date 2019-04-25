using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SolutionTracker
    {
        public string SolutionId { get; set; }
        public string TableName { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool IsSelected { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
