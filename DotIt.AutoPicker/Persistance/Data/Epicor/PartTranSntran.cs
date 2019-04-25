using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartTranSntran
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string SerialNumber { get; set; }
        public int SntranNum { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int PartTranTranNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
