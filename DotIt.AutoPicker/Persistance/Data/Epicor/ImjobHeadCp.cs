using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImjobHeadCp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
