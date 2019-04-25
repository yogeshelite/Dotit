using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PkgControlStation
    {
        public PkgControlStation()
        {
            PkgControlStationResource = new HashSet<PkgControlStationResource>();
        }

        public string Company { get; set; }
        public string StationId { get; set; }
        public string StationDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<PkgControlStationResource> PkgControlStationResource { get; set; }
    }
}
