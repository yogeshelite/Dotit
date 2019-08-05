using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImtaskType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public bool Inactive { get; set; }
        public bool Appointment { get; set; }
        public bool TimeTaskType { get; set; }
        public bool ExpenseTaskType { get; set; }
        public bool GlobalTaskType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
