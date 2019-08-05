using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImalcNfsrc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public int LookupTblMapUidObsolete { get; set; }
        public int TgtSeqNbrObsolete { get; set; }
        public int LinkUidObsolete { get; set; }
        public string BookId { get; set; }
        public int ParamOpt { get; set; }
        public int ParamSegmentNbr { get; set; }
        public string Coacode { get; set; }
        public int EntryType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int SrcSeqNbr { get; set; }
        public string SrcCodeId { get; set; }
    }
}
