using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZdataTableBackup
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string Description { get; set; }
        public string SchemaName { get; set; }
        public string DbtableName { get; set; }
        public string WhereClause { get; set; }
        public bool RestrictedByTer { get; set; }
        public bool RestrictedByPlant { get; set; }
        public bool FullSync { get; set; }
        public string TableType { get; set; }
        public bool SystemFlag { get; set; }
        public string TableLabel { get; set; }
        public string ChgLogId { get; set; }
        public string Boupdate { get; set; }
        public string UpdateMethod { get; set; }
        public string Cgccode { get; set; }
        public string Interface { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
