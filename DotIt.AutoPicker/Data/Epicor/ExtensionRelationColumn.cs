using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtensionRelationColumn
    {
        public string ExtensionSetId { get; set; }
        public string SystemCode { get; set; }
        public string DataSetId { get; set; }
        public string RelationId { get; set; }
        public int Seq { get; set; }
        public string ParentFieldName { get; set; }
        public string ChildFieldName { get; set; }
        public string CompOp { get; set; }
        public bool IsConst { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtensionRelation ExtensionRelation { get; set; }
    }
}
