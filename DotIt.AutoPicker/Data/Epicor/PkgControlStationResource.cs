using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PkgControlStationResource
    {
        public string Company { get; set; }
        public string StationId { get; set; }
        public int StationResourceSeq { get; set; }
        public string Plant { get; set; }
        public string ResourceId { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PkgControlStation PkgControlStation { get; set; }
    }
}
