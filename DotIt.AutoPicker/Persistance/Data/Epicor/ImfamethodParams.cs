using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfamethodParams
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
