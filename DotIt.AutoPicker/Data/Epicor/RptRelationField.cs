using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptRelationField
    {
        public string RptDefId { get; set; }
        public string RelationId { get; set; }
        public int Seq { get; set; }
        public string ParentFieldName { get; set; }
        public string ChildFieldName { get; set; }
        public string CompOp { get; set; }
        public bool IsConst { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptRelation R { get; set; }
    }
}
