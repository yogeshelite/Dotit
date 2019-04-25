using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImportGroup
    {
        public ImportGroup()
        {
            ImportFile = new HashSet<ImportFile>();
        }

        public string Company { get; set; }
        public long GroupId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ImportFile> ImportFile { get; set; }
    }
}
