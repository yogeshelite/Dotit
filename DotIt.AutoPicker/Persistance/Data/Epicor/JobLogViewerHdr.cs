using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JobLogViewerHdr
    {
        public JobLogViewerHdr()
        {
            JobLogViewerDtl = new HashSet<JobLogViewerDtl>();
        }

        public string Company { get; set; }
        public int LogNum { get; set; }
        public string Process { get; set; }
        public DateTime ExecutedDate { get; set; }
        public string Parameter { get; set; }
        public string Detail { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<JobLogViewerDtl> JobLogViewerDtl { get; set; }
    }
}
