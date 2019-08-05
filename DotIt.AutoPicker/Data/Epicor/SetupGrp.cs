using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SetupGrp
    {
        public string Company { get; set; }
        public string SetupGroup { get; set; }
        public string Description { get; set; }
        public int SchedPrecedence { get; set; }
        public bool DefaultSetupGroup { get; set; }
        public bool GlobalSetupGrp { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
