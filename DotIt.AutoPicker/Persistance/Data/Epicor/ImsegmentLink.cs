using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsegmentLink
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int SegmentLinkUid { get; set; }
        public int CoamapUid { get; set; }
        public string SourceCoa { get; set; }
        public int SourceSegment { get; set; }
        public string SourceSegValue { get; set; }
        public string TargetCoa { get; set; }
        public int TargetSegment { get; set; }
        public string TargetSegValue { get; set; }
        public DateTime? CreationDate { get; set; }
        public int CreationTime { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SegmentAbbrev { get; set; }
        public string SegmentDesc { get; set; }
    }
}
