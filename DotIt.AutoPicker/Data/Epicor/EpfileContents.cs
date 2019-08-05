using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EpfileContents
    {
        public string PackageId { get; set; }
        public string SourcePath { get; set; }
        public int FileContentType { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int? RunSequence { get; set; }
        public string Notes { get; set; }
    }
}
