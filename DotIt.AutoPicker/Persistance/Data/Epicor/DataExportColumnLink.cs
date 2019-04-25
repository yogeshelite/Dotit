using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DataExportColumnLink
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int ICounter { get; set; }
        public string TblColumnName { get; set; }
        public string ForeignTblColumnName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
