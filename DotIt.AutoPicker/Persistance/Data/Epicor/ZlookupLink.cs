using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZlookupLink
    {
        public ZlookupLink()
        {
            RptLinkTable = new HashSet<RptLinkTable>();
            ZlookupField = new HashSet<ZlookupField>();
        }

        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string LookupId { get; set; }
        public string ForeignSystemCode { get; set; }
        public string ForeignDataTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public bool IncludeLookupFields { get; set; }
        public bool ValidationRequired { get; set; }
        public string ValidationPhraseEx { get; set; }
        public bool SystemFlag { get; set; }
        public bool ValidationOnly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataTable Foreign { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
        public virtual ICollection<RptLinkTable> RptLinkTable { get; set; }
        public virtual ICollection<ZlookupField> ZlookupField { get; set; }
    }
}
