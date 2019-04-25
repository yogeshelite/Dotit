using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Wave
    {
        public string Company { get; set; }
        public int WaveNum { get; set; }
        public string WaveDesc { get; set; }
        public bool PickComplete { get; set; }
        public bool PickStarted { get; set; }
        public string DemandType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
