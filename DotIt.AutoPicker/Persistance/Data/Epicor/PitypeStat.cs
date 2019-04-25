using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PitypeStat
    {
        public string Company { get; set; }
        public string Pitype { get; set; }
        public string Pistatus { get; set; }
        public bool PostToGl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
