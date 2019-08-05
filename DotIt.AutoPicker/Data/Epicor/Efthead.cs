using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Efthead
    {
        public int EftheadUid { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Program { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
        public string Company { get; set; }
        public bool GlobalEfthead { get; set; }
        public bool GlobalLock { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ProgramCategory { get; set; }
    }
}
