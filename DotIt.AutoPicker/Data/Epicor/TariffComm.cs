using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TariffComm
    {
        public string Company { get; set; }
        public string TariffCode { get; set; }
        public string CommodityCode { get; set; }
        public bool GlobalTariffComm { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
