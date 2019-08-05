using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FamethodParamsSrc
    {
        public string Company { get; set; }
        public string AssetMethod { get; set; }
        public int ParamNbr { get; set; }
        public int LookupTblMapUid { get; set; }
        public int TgtSeqNbr { get; set; }
        public int LinkUid { get; set; }
        public int ParamOpt { get; set; }
        public int ParamSegmentNbr { get; set; }
        public int EntryType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
