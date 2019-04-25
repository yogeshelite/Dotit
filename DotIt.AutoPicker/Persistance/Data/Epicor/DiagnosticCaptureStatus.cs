using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DiagnosticCaptureStatus
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string DiagnosticName { get; set; }
        public long Bookmark { get; set; }
        public bool CaptureEnabled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
