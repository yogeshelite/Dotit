using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbUomclass
    {
        public bool Active { get; set; }
        public string BaseUomcode { get; set; }
        public string ClassType { get; set; }
        public string Company { get; set; }
        public string DefUomCode { get; set; }
        public string Description { get; set; }
        public string UomclassId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbUomclassId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalUomclass { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
