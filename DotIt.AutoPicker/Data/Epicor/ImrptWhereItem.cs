using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrptWhereItem
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
