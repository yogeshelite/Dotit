using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtensionRelation
    {
        public ExtensionRelation()
        {
            ExtensionRelationColumn = new HashSet<ExtensionRelationColumn>();
        }

        public string ExtensionSetId { get; set; }
        public string SystemCode { get; set; }
        public string DataSetId { get; set; }
        public string RelationId { get; set; }
        public string ParentSystemCode { get; set; }
        public string ParentDataTableId { get; set; }
        public string ChildSystemCode { get; set; }
        public string ChildDataTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public int Type { get; set; }
        public bool TreatAsPeer { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataTable Child { get; set; }
        public virtual ExtensionSet ExtensionSet { get; set; }
        public virtual ZdataTable Parent { get; set; }
        public virtual ZdataSet ZdataSet { get; set; }
        public virtual ICollection<ExtensionRelationColumn> ExtensionRelationColumn { get; set; }
    }
}
