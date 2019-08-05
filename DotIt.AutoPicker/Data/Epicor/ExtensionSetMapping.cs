using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtensionSetMapping
    {
        public string Company { get; set; }
        public string ExtensionSetId { get; set; }
        public int Order { get; set; }
        public bool Disabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysCompany CompanyNavigation { get; set; }
        public virtual ExtensionSet ExtensionSet { get; set; }
    }
}
