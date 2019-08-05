using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MemoCat
    {
        public string Company { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToFile { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public bool GlobalMemoCat { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
