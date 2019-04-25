using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZsubDataSet
    {
        public string SystemCode { get; set; }
        public string ParentDataSetId { get; set; }
        public string DataTableSystemCode { get; set; }
        public string DataTableId { get; set; }
        public bool IsPrimaryTable { get; set; }
        public bool GenAttachments { get; set; }
        public bool SystemFlag { get; set; }
        public bool ExcludeUpdate { get; set; }
        public bool ExcludeGet { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataTable DataTable { get; set; }
        public virtual ZdataSet ZdataSet { get; set; }
    }
}
