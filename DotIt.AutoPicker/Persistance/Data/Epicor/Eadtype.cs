using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Eadtype
    {
        public string Company { get; set; }
        public string Eadtype1 { get; set; }
        public string DefineBy { get; set; }
        public DateTime? EarliestApplyDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
