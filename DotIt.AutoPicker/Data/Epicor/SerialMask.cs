using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SerialMask
    {
        public string Company { get; set; }
        public string SerialMaskId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int MaskType { get; set; }
        public string Mask { get; set; }
        public string Example { get; set; }
        public int CharactersUsed { get; set; }
        public int PrefixLength { get; set; }
        public int SuffixLength { get; set; }
        public string GenerateSeqString { get; set; }
        public string SnlastUsedSeq { get; set; }
        public bool GlobalSerialMask { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
