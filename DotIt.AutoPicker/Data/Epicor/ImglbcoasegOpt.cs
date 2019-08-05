using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbcoasegOpt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public string SegmentCode { get; set; }
        public int SubSegmentNbr { get; set; }
        public string ValOption { get; set; }
        public string DefaultSegment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
