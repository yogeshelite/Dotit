using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptLinkTable
    {
        public RptLinkTable()
        {
            RptLinkField = new HashSet<RptLinkField>();
        }

        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string RptLinkId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public string ZlookupId { get; set; }
        public string Description { get; set; }
        public string KeyId { get; set; }
        public string ForeignRptTableId { get; set; }
        public string ForeignSystemCode { get; set; }
        public string ForeignZtableId { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptTable Rpt { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
        public virtual ZlookupLink ZlookupLink { get; set; }
        public virtual ICollection<RptLinkField> RptLinkField { get; set; }
    }
}
