using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImmschedItem
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BatchJobNum { get; set; }
        public string JobNum { get; set; }
        public string ParentJobNum { get; set; }
        public DateTime? ReqDueDate { get; set; }
        public bool IsChild { get; set; }
        public bool IsParent { get; set; }
        public int InternalOrder { get; set; }
        public int Order { get; set; }
        public bool RemoveFromSchedule { get; set; }
        public bool Scheduled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
