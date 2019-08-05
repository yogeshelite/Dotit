using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ControlIdextractPcid
    {
        public string Company { get; set; }
        public string DataIdentifierCode { get; set; }
        public string DataIdentifierDesc { get; set; }
        public string DataIdentifier { get; set; }
        public bool Inactive { get; set; }
        public int ExtractSequence { get; set; }
        public int DigitsToExtract { get; set; }
        public bool IsFixedLength { get; set; }
        public int DigitsInString { get; set; }
        public string ExtractComments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int ScanMinLength { get; set; }
        public int ScanMaxLength { get; set; }
    }
}
