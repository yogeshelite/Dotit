using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysSequence
    {
        public string Name { get; set; }
        public int InitialValue { get; set; }
        public int CurrentValue { get; set; }
        public int Increment { get; set; }
        public int Maximum { get; set; }
        public bool Cycle { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
