using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustomizationProjectItem
    {
        public string CustomizationType { get; set; }
        public string Project { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int Kind { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual CustomizationProject CustomizationProject { get; set; }
    }
}
