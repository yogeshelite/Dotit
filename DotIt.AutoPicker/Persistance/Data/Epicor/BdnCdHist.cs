using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BdnCdHist
    {
        public string Company { get; set; }
        public string BdnCd { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int Seq { get; set; }
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
