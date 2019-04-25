using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbSchedPri
    {
        public bool BackwardsSched { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int ImageNum { get; set; }
        public bool MinimizeWip { get; set; }
        public int PriorityFactor { get; set; }
        public string SchedCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSchedCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSchedPri { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
