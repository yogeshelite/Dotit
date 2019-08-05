using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VntgStat
    {
        public string Company { get; set; }
        public string Module { get; set; }
        public DateTime? RunDate { get; set; }
        public int RunTime { get; set; }
        public string DcdUserId { get; set; }
        public int ElapsedTime { get; set; }
        public string Comment { get; set; }
        public DateTime? CutOffDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
