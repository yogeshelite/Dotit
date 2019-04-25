using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MschedItem
    {
        public MschedItem()
        {
            MschedRelItem = new HashSet<MschedRelItem>();
        }

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

        public virtual ICollection<MschedRelItem> MschedRelItem { get; set; }
    }
}
