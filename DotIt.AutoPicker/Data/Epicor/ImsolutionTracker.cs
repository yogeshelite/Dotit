using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImsolutionTracker
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
