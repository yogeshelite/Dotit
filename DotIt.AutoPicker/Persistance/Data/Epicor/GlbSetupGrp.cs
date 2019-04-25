using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSetupGrp
    {
        public string Company { get; set; }
        public bool DefaultSetupGroup { get; set; }
        public string Description { get; set; }
        public int SchedPrecedence { get; set; }
        public string SetupGroup { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSetupGroup { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSetupGrp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
