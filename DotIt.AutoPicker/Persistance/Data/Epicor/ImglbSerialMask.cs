using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbSerialMask
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool Active { get; set; }
        public int CharactersUsed { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string GenerateSeqString { get; set; }
        public string Mask { get; set; }
        public int MaskType { get; set; }
        public int PrefixLength { get; set; }
        public string SerialMaskId { get; set; }
        public string SnlastUsedSeq { get; set; }
        public int SuffixLength { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSerialMaskId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSerialMask { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
