using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrptLinkTable
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
