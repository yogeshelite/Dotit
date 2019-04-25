using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Paday
    {
        public string Company { get; set; }
        public string PadayId { get; set; }
        public string Description { get; set; }
        public string PadayType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
