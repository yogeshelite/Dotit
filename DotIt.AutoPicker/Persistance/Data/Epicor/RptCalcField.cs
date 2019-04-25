using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptCalcField
    {
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

        public virtual RptTable Rpt { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
    }
}
