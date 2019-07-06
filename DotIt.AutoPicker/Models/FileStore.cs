using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Models
{
    public partial class FileStore
    {
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
