using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtensionSet
    {
        public ExtensionSet()
        {
            Extension = new HashSet<Extension>();
            ExtensionDataSetTable = new HashSet<ExtensionDataSetTable>();
            ExtensionRelation = new HashSet<ExtensionRelation>();
            ExtensionSetMapping = new HashSet<ExtensionSetMapping>();
        }

        public string ExtensionSetId { get; set; }
        public string Provider { get; set; }
        public string Product { get; set; }
        public string Assembly { get; set; }
        public string Version { get; set; }
        public int Level { get; set; }
        public bool Disabled { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<Extension> Extension { get; set; }
        public virtual ICollection<ExtensionDataSetTable> ExtensionDataSetTable { get; set; }
        public virtual ICollection<ExtensionRelation> ExtensionRelation { get; set; }
        public virtual ICollection<ExtensionSetMapping> ExtensionSetMapping { get; set; }
    }
}
