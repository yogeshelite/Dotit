using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustomizationProject
    {
        public CustomizationProject()
        {
            CustomizationProjectItem = new HashSet<CustomizationProjectItem>();
        }

        public string CustomizationType { get; set; }
        public string Project { get; set; }
        public string Settings { get; set; }
        public string References { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<CustomizationProjectItem> CustomizationProjectItem { get; set; }
    }
}
