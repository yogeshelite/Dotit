using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrptTable
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
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public decimal SeqControl { get; set; }
        public string ParentRptTableId { get; set; }
        public bool PrimaryTable { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IsSystemTable { get; set; }
        public string QueryId { get; set; }
        public string EftheadCompany { get; set; }
        public int? EftheadUid { get; set; }
    }
}
