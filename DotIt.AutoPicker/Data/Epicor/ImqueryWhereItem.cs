using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImqueryWhereItem
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public string TableId { get; set; }
        public Guid CriteriaId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string CompOp { get; set; }
        public string AndOr { get; set; }
        public bool Neg { get; set; }
        public string LeftP { get; set; }
        public string RightP { get; set; }
        public bool IsConst { get; set; }
        public int CriteriaType { get; set; }
        public string ToTableId { get; set; }
        public string ToFieldName { get; set; }
        public string ToDataType { get; set; }
        public string Rvalue { get; set; }
        public bool ExtSecurity { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
