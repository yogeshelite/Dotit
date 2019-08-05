using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Substance
    {
        public string Company { get; set; }
        public string SubstanceId { get; set; }
        public string Description { get; set; }
        public bool GlobalSubstance { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
