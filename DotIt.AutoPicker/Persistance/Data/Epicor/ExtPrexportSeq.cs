using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtPrexportSeq
    {
        public string Company { get; set; }
        public string PayExportLayoutId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ColumnTitle { get; set; }

        public virtual ExtPrexportLayout ExtPrexportLayout { get; set; }
        public virtual ExtPrexportSrcTbl ExtPrexportSrcTbl { get; set; }
    }
}
