using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptRelation
    {
        public RptRelation()
        {
            RptRelationField = new HashSet<RptRelationField>();
        }

        public string RptDefId { get; set; }
        public string RelationId { get; set; }
        public string ParentRptTableId { get; set; }
        public string ChildRptTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public string WhichItem { get; set; }
        public string JoinType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptDataDef RptDef { get; set; }
        public virtual ICollection<RptRelationField> RptRelationField { get; set; }
    }
}
