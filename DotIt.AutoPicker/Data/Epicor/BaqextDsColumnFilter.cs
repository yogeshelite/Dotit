using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BaqextDsColumnFilter
    {
        public string Company { get; set; }
        public string DatasourceType { get; set; }
        public Guid FilterId { get; set; }
        public int Seq { get; set; }
        public string AndOr { get; set; }
        public bool Neg { get; set; }
        public string LeftP { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string RightP { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
