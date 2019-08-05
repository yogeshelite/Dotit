using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BsbdnRt
    {
        public string Company { get; set; }
        public string BdnSetId { get; set; }
        public string BdnCd { get; set; }
        public DateTime? EffDte { get; set; }
        public decimal ProvPcnt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
