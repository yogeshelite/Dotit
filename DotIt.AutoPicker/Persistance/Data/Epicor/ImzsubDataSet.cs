using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImzsubDataSet
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
