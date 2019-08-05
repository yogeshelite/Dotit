using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaskSet
    {
        public string Company { get; set; }
        public string TaskSetId { get; set; }
        public string TaskSetDescription { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeUserId { get; set; }
        public bool Inactive { get; set; }
        public int FirstTaskSeq { get; set; }
        public string WorkflowType { get; set; }
        public bool EcocheckOutAllowed { get; set; }
        public bool EcocheckInAllowed { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
