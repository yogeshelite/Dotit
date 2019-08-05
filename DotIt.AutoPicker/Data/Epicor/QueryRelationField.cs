using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryRelationField
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public Guid RelationId { get; set; }
        public int Seq { get; set; }
        public string ParentFieldName { get; set; }
        public string ParentFieldDataType { get; set; }
        public bool ParentFieldIsExpr { get; set; }
        public string ChildFieldName { get; set; }
        public string ChildFieldDataType { get; set; }
        public bool ChildFieldIsExpr { get; set; }
        public string AndOr { get; set; }
        public bool Neg { get; set; }
        public string LeftP { get; set; }
        public string RightP { get; set; }
        public string CompOp { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
