using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryField
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public string TableId { get; set; }
        public string FieldName { get; set; }
        public int Seq { get; set; }
        public string DbschemaName { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public bool External { get; set; }
        public bool IsCalculated { get; set; }
        public string Formula { get; set; }
        public string FieldFormat { get; set; }
        public string FieldLabel { get; set; }
        public string LikeDataFieldTableId { get; set; }
        public int LikeDataFieldSeq { get; set; }
        public string Aggregation { get; set; }
        public bool IsGroupBy { get; set; }
        public bool UseLike { get; set; }
        public string LikeDataFieldName { get; set; }
        public bool Updatable { get; set; }
        public bool RaiseEvent { get; set; }
        public string QuickSearchId { get; set; }
        public bool DropDown { get; set; }
        public string UpdInitExpression { get; set; }
        public string Alias { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public string DefaultValue { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
