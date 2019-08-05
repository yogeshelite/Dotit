using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Dcrmlic
    {
        public string DeviceId { get; set; }
        public decimal SerialNum { get; set; }
        public int SerialNumSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
