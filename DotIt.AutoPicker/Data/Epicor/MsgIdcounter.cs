using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MsgIdcounter
    {
        public string Company { get; set; }
        public string MsgIdcounter1 { get; set; }
        public int Sequence { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
