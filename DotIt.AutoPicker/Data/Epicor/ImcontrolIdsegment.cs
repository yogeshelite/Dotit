using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcontrolIdsegment
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ControlIdcode { get; set; }
        public int SegmentNum { get; set; }
        public int SegmentPosition { get; set; }
        public string SegmentType { get; set; }
        public string SegmentFormat { get; set; }
        public string AlphaRangeFrom { get; set; }
        public string AlphaRangeTo { get; set; }
        public long NumericRangeFrom { get; set; }
        public long NumericRangeTo { get; set; }
        public string RolloverTrigger { get; set; }
        public string RolloverAction { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SegmentDesc { get; set; }
        public bool IsFixedLength { get; set; }
    }
}
