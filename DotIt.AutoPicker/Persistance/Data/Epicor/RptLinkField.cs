using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptLinkField
    {
        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string RptLinkId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public string ZlookupId { get; set; }
        public string FieldName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptLinkTable RptLinkTable { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
    }
}
