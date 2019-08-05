using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProcessSet
    {
        public ProcessSet()
        {
            ProcessTask = new HashSet<ProcessTask>();
        }

        public string Company { get; set; }
        public string SystemCode { get; set; }
        public string ProcessId { get; set; }
        public string Description { get; set; }
        public bool SystemProcess { get; set; }
        public bool IsAsynchronous { get; set; }
        public bool IsConversion { get; set; }
        public string RunLevel { get; set; }
        public string RunPatchLevel { get; set; }
        public string ProgStatus { get; set; }
        public DateTime? RunOn { get; set; }
        public string RunUserId { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ProcessTask> ProcessTask { get; set; }
    }
}
