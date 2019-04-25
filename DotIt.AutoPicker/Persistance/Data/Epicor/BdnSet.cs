using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BdnSet
    {
        public string Company { get; set; }
        public string BdnSetId { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool GlobalBdnSet { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
