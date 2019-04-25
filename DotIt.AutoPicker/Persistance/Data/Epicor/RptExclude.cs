using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptExclude
    {
        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public string ZfieldName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExcludeColumn { get; set; }
        public bool ExcludeLabel { get; set; }

        public virtual RptTable Rpt { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
    }
}
