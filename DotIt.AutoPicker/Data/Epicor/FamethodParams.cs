using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FamethodParams
    {
        public string Company { get; set; }
        public string AssetMethod { get; set; }
        public int ParamNbr { get; set; }
        public string ParamName { get; set; }
        public int ParamType { get; set; }
        public string ParamDesc { get; set; }
        public int MapUid { get; set; }
        public int LinkUid { get; set; }
        public int TgtSeqNbr { get; set; }
        public bool InActive { get; set; }
        public string BaqexportId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
