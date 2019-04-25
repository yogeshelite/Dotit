using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CheckDigit
    {
        public string CountryIsocode { get; set; }
        public string CheckDigitId { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public int Modulus { get; set; }
        public bool UseLengthInCheckDigit { get; set; }
        public int ProductType { get; set; }
        public int SpecialRemainder { get; set; }
        public string RemainderCharacter { get; set; }
        public string RemainderFormat { get; set; }
        public bool StartFromLeft { get; set; }
        public bool IsRecursive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
