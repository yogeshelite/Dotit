using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImzlookupLink
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
