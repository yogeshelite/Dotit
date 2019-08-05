using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Uomclass
    {
        public string Company { get; set; }
        public string UomclassId { get; set; }
        public string Description { get; set; }
        public string ClassType { get; set; }
        public string BaseUomcode { get; set; }
        public string DefUomCode { get; set; }
        public bool Active { get; set; }
        public bool GlobalUomclass { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
