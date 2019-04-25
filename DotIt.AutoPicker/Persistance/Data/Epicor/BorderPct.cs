using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BorderPct
    {
        public string Company { get; set; }
        public int DestCountryNum { get; set; }
        public decimal PctAtBorder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
