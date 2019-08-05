using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcontrolIdextractSegment
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ControlIdextractCode { get; set; }
        public int SegmentNum { get; set; }
        public string SegmentType { get; set; }
        public string DataIdentifier { get; set; }
        public int PcidsegmentPosition { get; set; }
        public int SegmentPosition { get; set; }
        public int StartCharacterPosition { get; set; }
        public int EndCharacterPosition { get; set; }
        public string DevCharacter01 { get; set; }
        public string DevCharacter02 { get; set; }
        public int DevInteger01 { get; set; }
        public int DevInteger02 { get; set; }
        public bool DevBoolean01 { get; set; }
        public bool DevBoolean02 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
