using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZlinkColumn
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string LinkId { get; set; }
        public string FieldName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataTable ZdataTable { get; set; }
    }
}
