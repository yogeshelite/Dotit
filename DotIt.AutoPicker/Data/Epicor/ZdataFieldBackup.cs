using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZdataFieldBackup
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public int Seq { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DataType { get; set; }
        public bool UseDbdefault { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public string Description { get; set; }
        public bool External { get; set; }
        public string Formula { get; set; }
        public bool Included { get; set; }
        public string FieldFormat { get; set; }
        public int FieldScale { get; set; }
        public string FieldLabel { get; set; }
        public string InitialValue { get; set; }
        public string ToolTipText { get; set; }
        public bool IsDescriptionField { get; set; }
        public string LikeDataFieldSystemCode { get; set; }
        public string LikeDataFieldTableId { get; set; }
        public string RequiredModules { get; set; }
        public string Delimiters { get; set; }
        public string ValidationMsg { get; set; }
        public string CodeDescriptionList { get; set; }
        public string LikeDataFieldName { get; set; }
        public bool SystemFlag { get; set; }
        public string CurrencyCodeColumn { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencySource { get; set; }
        public string BizType { get; set; }
        public string UdlikeDataFieldSystemCode { get; set; }
        public string UdlikeDataFieldTableId { get; set; }
        public string UdlikeDataFieldName { get; set; }
        public string UdfieldFormat { get; set; }
        public string UdfieldLabel { get; set; }
        public string UdinitialValue { get; set; }
        public bool Udrequired { get; set; }
        public bool UdreadOnly { get; set; }
        public string UdcurrencyCodeColumn { get; set; }
        public string UdcurrencyType { get; set; }
        public string UdcurrencySource { get; set; }
        public string UdpredictiveSearchId { get; set; }
        public string Cgccode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
