using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaskType
    {
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
