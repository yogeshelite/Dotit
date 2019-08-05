using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysBigSequence
    {
        public string Name { get; set; }
        public long InitialValue { get; set; }
        public long CurrentValue { get; set; }
        public int Increment { get; set; }
        public long Maximum { get; set; }
        public bool Cycle { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
