using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ReservePri
    {
        public string Company { get; set; }
        public string PriorityCode { get; set; }
        public string Description { get; set; }
        public int PriorityAdj { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
