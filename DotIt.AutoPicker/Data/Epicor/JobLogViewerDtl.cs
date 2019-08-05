using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobLogViewerDtl
    {
        public string Company { get; set; }
        public int LogNum { get; set; }
        public string JobNum { get; set; }
        public string Parameter { get; set; }
        public string Detail { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual JobLogViewerHdr JobLogViewerHdr { get; set; }
    }
}
