using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imecogroup
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Description { get; set; }
        public bool GroupClosed { get; set; }
        public string CommentText { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosedBy { get; set; }
        public int ClosedTime { get; set; }
        public string Eco { get; set; }
        public string TaskSetId { get; set; }
        public string CurrentWfstageId { get; set; }
        public string ActiveTaskId { get; set; }
        public string LastTaskId { get; set; }
        public bool CheckInAllowed { get; set; }
        public string PrimeSalesRepCode { get; set; }
        public string WfgroupId { get; set; }
        public bool CheckOutAllowed { get; set; }
        public bool Wfcomplete { get; set; }
        public bool SingleUser { get; set; }
        public bool GrpLocked { get; set; }
        public string GrpLockedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
