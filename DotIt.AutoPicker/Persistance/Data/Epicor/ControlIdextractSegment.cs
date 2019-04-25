using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ControlIdextractSegment
    {
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

        public virtual ControlIdextractHeader Co { get; set; }
    }
}
