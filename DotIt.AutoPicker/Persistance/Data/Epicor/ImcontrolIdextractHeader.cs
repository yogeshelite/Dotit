using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcontrolIdextractHeader
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
    }
}
