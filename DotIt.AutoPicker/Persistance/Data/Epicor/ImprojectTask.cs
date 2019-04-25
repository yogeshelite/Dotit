using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprojectTask
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string TaskId { get; set; }
        public string Description { get; set; }
        public string CommentText { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal PercentComplete { get; set; }
        public DateTime? DateComplete { get; set; }
        public string TaskStatus { get; set; }
        public string PersonId { get; set; }
        public string PhaseId { get; set; }
        public string MsptaskId { get; set; }
        public string Msppredecessor { get; set; }
        public string UserMapData { get; set; }
        public string TypeId { get; set; }
        public decimal Duration { get; set; }
        public string DurationType { get; set; }
        public string PersonList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
