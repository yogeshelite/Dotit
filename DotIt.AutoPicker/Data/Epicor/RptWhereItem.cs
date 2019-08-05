using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptWhereItem
    {
        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public string CompOp { get; set; }
        public bool IsConst { get; set; }
        public string ToTableId { get; set; }
        public string ToSystemCode { get; set; }
        public string ToZtableId { get; set; }
        public string ToFieldName { get; set; }
        public string AndOr { get; set; }
        public bool Neg { get; set; }
        public string Rvalue { get; set; }
        public int NumLeftP { get; set; }
        public int NumRightP { get; set; }
        public int ParentSeq { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptTable Rpt { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
    }
}
