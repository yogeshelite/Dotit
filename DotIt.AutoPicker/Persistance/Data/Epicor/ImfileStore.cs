using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfileStore
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public Guid SysRowId { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTable { get; set; }
        public string Company { get; set; }
        public string TenantId { get; set; }
        public string SecCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string Category { get; set; }
        public string FileType { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
