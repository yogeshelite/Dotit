using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobHeadCp
    {
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public string GlbJobNum { get; set; }
        public bool GlbJobComplete { get; set; }
        public bool GlbJobClosed { get; set; }
        public bool GlbJobFirm { get; set; }
        public bool GlbJobEngineered { get; set; }
        public string GlbProdCode { get; set; }
        public string GlbProjectId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
