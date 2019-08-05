using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhseGroupTrans
    {
        public string Company { get; set; }
        public string WhseGroupCode { get; set; }
        public string TransCode { get; set; }
        public int TransPriority { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
