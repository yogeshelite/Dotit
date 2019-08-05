using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptStructuredOutputFileElement
    {
        public string Company { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public string RptStructuredOutputFileId { get; set; }
        public int ElementId { get; set; }
        public string ElementName { get; set; }
        public int? ParentElementId { get; set; }
        public int ChildSequence { get; set; }
        public string Namespace { get; set; }
        public string Prefix { get; set; }
        public bool Xmlattribute { get; set; }
        public int? AggregationType { get; set; }
        public int? DecimalScale { get; set; }
        public string DataSourceId { get; set; }
        public string DataSourceColumn { get; set; }
        public bool IsConstant { get; set; }
        public string ConstantValue { get; set; }
        public string CalculationEftheadCompany { get; set; }
        public int? CalculationEftheadUid { get; set; }
        public string CalculationName { get; set; }
        public string AdditionalSettings { get; set; }
        public string DateFormat { get; set; }
        public bool SystemFlag { get; set; }
        public bool Jsonobject { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string ChangedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ElementDataType { get; set; }
        public string ElementDescription { get; set; }
        public bool EmptyStringGenerateEmptyElement { get; set; }
        public bool EmptyStringSuppressOrNullElement { get; set; }
        public bool EmptyStringSubsituteElement { get; set; }
        public string EmptyStringSubsituteValue { get; set; }
        public bool ZeroNumericSuppress { get; set; }

        public virtual RptStructuredOutputFile RptStructuredOutput { get; set; }
    }
}
