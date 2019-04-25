using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtensionDataSetTable
    {
        public string ExtensionSetId { get; set; }
        public string SystemCode { get; set; }
        public string ParentDataSetId { get; set; }
        public string DataTableSystemCode { get; set; }
        public string DataTableId { get; set; }
        public bool IsPrimaryTable { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool GenImtable { get; set; }

        public virtual ZdataTable DataTable { get; set; }
        public virtual ExtensionSet ExtensionSet { get; set; }
        public virtual ZdataSet ZdataSet { get; set; }
    }
}
