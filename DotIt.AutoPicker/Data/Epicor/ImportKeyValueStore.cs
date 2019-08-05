using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportKeyValueStore
    {
        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public long ImportRowNum { get; set; }
        public long ImportColNum { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public Guid RowGuid { get; set; }
        public int Jsonindex { get; set; }
        public string Jsonpath { get; set; }
        public string DataCharacter { get; set; }
        public DateTime? DataDate { get; set; }
        public bool DataLogical { get; set; }
        public int DataInteger { get; set; }
        public decimal DataDecimal { get; set; }
        public long DataLong { get; set; }
        public Guid DataGuid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ImportDocument ImportDocument { get; set; }
    }
}
