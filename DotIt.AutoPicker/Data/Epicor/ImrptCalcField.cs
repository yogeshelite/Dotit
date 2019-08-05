using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrptCalcField
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
        public string FieldName { get; set; }
        public string FieldLabel { get; set; }
        public string DataType { get; set; }
        public string FieldFormat { get; set; }
        public int FieldLength { get; set; }
        public int FieldPrecision { get; set; }
        public bool DecimalCurDepended { get; set; }
        public string DecimalValueType { get; set; }
        public string DecimalCurrencyType { get; set; }
        public string DecimalCurCodeField { get; set; }
        public string BizType { get; set; }
        public string ZfieldName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
