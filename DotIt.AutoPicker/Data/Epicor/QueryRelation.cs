using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryRelation
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public Guid RelationId { get; set; }
        public bool IsFk { get; set; }
        public string ParentTableId { get; set; }
        public string ChildTableId { get; set; }
        public string JoinType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
