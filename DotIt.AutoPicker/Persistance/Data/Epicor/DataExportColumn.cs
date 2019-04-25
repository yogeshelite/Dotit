using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DataExportColumn
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Description { get; set; }
        public string ColumnType { get; set; }
        public int Accuracy { get; set; }
        public bool IsVarPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        public string ForeignKeyTableName { get; set; }
        public string ForeignKeyColumnName { get; set; }
        public int ColumnOrder { get; set; }
        public string FooterStype { get; set; }
        public int FooterSorder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Alias { get; set; }
        public string FooterSnode { get; set; }
        public bool IsHidden { get; set; }
        public string DisplayName { get; set; }
    }
}
