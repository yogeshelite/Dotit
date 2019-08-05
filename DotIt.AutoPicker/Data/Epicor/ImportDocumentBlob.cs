using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportDocumentBlob
    {
        public long BlobId { get; set; }
        public string ForeignSchemaName { get; set; }
        public string ForeignTableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string ContentType { get; set; }
        public string Contents { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
