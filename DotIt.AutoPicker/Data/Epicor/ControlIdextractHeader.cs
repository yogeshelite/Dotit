using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ControlIdextractHeader
    {
        public ControlIdextractHeader()
        {
            ControlIdextractSegment = new HashSet<ControlIdextractSegment>();
        }

        public string Company { get; set; }
        public string ControlIdextractCode { get; set; }
        public string ControlIdextractDesc { get; set; }
        public int ExtractSequence { get; set; }
        public string DataIdentifier { get; set; }
        public bool IsFixedLength { get; set; }
        public int DigitsInString { get; set; }
        public string DataFormat { get; set; }
        public string GroupSeparatorCharacter { get; set; }
        public string RecordSeparatorCharacter { get; set; }
        public string EndOfTransmissionCharacter { get; set; }
        public string ExtractComments { get; set; }
        public string Dimension { get; set; }
        public string DevCharacter01 { get; set; }
        public string DevCharacter02 { get; set; }
        public int DevInteger01 { get; set; }
        public int DevInteger02 { get; set; }
        public bool DevBoolean01 { get; set; }
        public bool DevBoolean02 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ControlIdextractSegment> ControlIdextractSegment { get; set; }
    }
}
