using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BaqextDsColumn
    {
        public string Company { get; set; }
        public string DatasourceType { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string FieldFormat { get; set; }
        public string FieldLabel { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
